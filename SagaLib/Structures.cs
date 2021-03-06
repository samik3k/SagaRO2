using System;
using System.Collections.Generic;
using System.Text;

namespace SagaLib
{

    /// <summary>
    /// Defines the base class of a network packet. Packets are send back and forth between the client 
    /// and server. Different types of packets are used for different purposes. The general packet structure
    /// is: PACKET_SIZE (2 bytes), PACKET_ID (2 bytes), PACKET_DATA (x bytes). The id bytes are considered to
    /// be part of the data bytes.
    /// The size bytes are unencrypted, but the id bytes and all data following are encrypted.
    /// </summary>
    public class Packet
    {
        /// <summary>
        /// The size of the packet is equal to the number of data bytes plus 2 bytes for the message id plus 2 bytes for the size.
        /// </summary>
        public ushort size;

        /// <summary>
        /// The data bytes (note: these include the id bytes and the size bytes)
        /// </summary>
        public byte[] data;

        /// <summary>
        /// Our current offset in the data array. After creation this will be set to 4 (the first
        /// non ID data byte)
        /// </summary>
        public ushort offset;
        public bool isGateway;
        public bool isFullheader;
        /// <summary>
        /// If true, the data byte array will be cloned before it gets encrypted.
        /// Set it to "true" if you want to send the packet multiple times.
        /// </summary>
        public bool doNotEncryptBuffer;


        /// <summary>
        /// Create a new packet with the given data bytes. The size and offset are set automatically.
        /// </summary>
        /// <param name="data">The (unencrypted) data bytes</param>
        public Packet(byte[] data)
        {
            this.size = (ushort) (data.Length + 2);
            this.data = new byte[this.size];
            data.CopyTo(this.data,2);
            this.offset = 4;
            this.doNotEncryptBuffer = false;
        }

        /// <summary>
        /// Create a new packet with the given length. The data bytes are initialized to all zeroes.
        /// </summary>
        /// <param name="length">Length of the data bytes.</param>
        public Packet(short length)
        {
            this.size = (ushort)(length);
            this.data = new byte[length];
            this.offset = 4;
            this.doNotEncryptBuffer = false;
        }

        /// <summary>
        /// Create a new packet with no data bytes at all. The data array has to be initialized manually.
        /// </summary>
        public Packet()
        {
            this.size = 0;
            this.offset = 4;
            this.doNotEncryptBuffer = false;
        }

        /// <summary>
        /// Check to see if a given size is ok for a certain packet.
        /// </summary>
        /// <param name="size">Size to compare with.</param>
        /// <returns>true: size is ok. false: size is not ok.</returns>
        public virtual bool SizeIsOk(ushort size) {

            if (this.isStaticSize())
            {
                if (!this.isGateway)
                {
                    if (size == this.size + 4 || size == this.size) return true;
                }
                else
                {
                    if (size == this.size) return true;
                }
            }
            else
            {
                if (size >= this.size) return true;
            }
            return false;
   
        }

        /// <summary>
        /// Create a new instance of this packet.
        /// </summary>
        /// <returns></returns>

        public virtual Packet New()
        {
            return new Packet();
        }

        /// <summary>
        /// Parse this packet (only used for GetPackets)
        /// </summary>
        public virtual void Parse(Client client)
        {
            return;
        }

        /// <summary>
        /// Get/Set the ID of the packet
        /// </summary>
        public ushort ID
        {
            get
            {
                if (!isGateway)
                    return (ushort)(data[3] + (data[2] << 8));
                else
                {
                    if(!isFullheader)
                        return (ushort)(data[7] + (data[6] << 8));
                    else
                        return (ushort)(data[13] + (data[12] << 8));
                }
            }
            set
            {
                byte[] idbytes = BitConverter.GetBytes(value);
                if (!isGateway)
                {
                    data[2] = idbytes[1];
                    data[3] = idbytes[0];
                }
                else
                {
                    if (!isFullheader)
                    {
                        data[6] = idbytes[1];
                        data[7] = idbytes[0];
                    }
                    else
                    {
                        data[12] = idbytes[1];
                        data[13] = idbytes[0];
                    }
                }
            }
        }
        public uint SessionID
        {
            get
            {
                return (uint)(data[2] + (data[3] << 8) + (data[4] << 16) + (data[5] << 24));
            }
            set
            {
                byte[] idbytes = BitConverter.GetBytes(value);

                data[2] = idbytes[0];
                data[3] = idbytes[1];
                data[4] = idbytes[2];
                data[5] = idbytes[3];
            }
        }
        
        public ushort ServerID
        {
            get
            {
                if (!isGateway)
                    return 0;
                else
                    return (ushort)(data[7] + (data[6] << 8));

            }
            set
            {
                byte[] idbytes = BitConverter.GetBytes(value);
                if (isGateway)
                {
                    data[6] = idbytes[1];
                    data[7] = idbytes[0];
                }
            }
        }


        /// <summary>
        /// Write the data length to the first 2 bytes of the packet.
        /// </summary>
        public void SetLength()
        {
            ushort tLen = (ushort)(data.Length);
            byte[] length = BitConverter.GetBytes(tLen);
            data[0] = length[0];
            data[1] = length[1];
        }

        public virtual bool isStaticSize() { return true; }

        /// <summary>
        /// Get the Unicode string starting at index.
        /// </summary>
        /// <param name="index">Index of the string.</param>
        /// <returns>String representation.</returns>
        public string GetString(ushort index) {
            if (!this.isGateway && index != 0) index += 4;
            ushort end = index;
            while (end < size)
            {
                if (data[end] == 0 && data[end + 1] == 0)
                {
                    if ((end - index) % 2 != 0) end++;
                    break;
                }
                else
                    end++;
            }
            offset = (ushort)(end + 2);            
           
            return Global.Unicode.GetString(data, index, end - index);
        }

        /// <summary>
        /// Get the Unicode string at the current offset.
        /// </summary>
        /// <returns>String representation.</returns>
        public string GetString()
        {
            return GetString(offset);
        }


        /// <summary>
        /// Get the Unicode string starting at index.
        /// </summary>
        /// <param name="index">Index of the string.</param>
        /// <returns>String representation.</returns>
        public string GetStringFixedSize(ushort index,ushort size)
        {
            if (!this.isGateway && index != 0) index += 4;
            if ((index + size) <= this.data.Length)
            {
                offset += size;
                return Global.Unicode.GetString(data, index, size);
            }
            else return "OUT_OF_RANGE";
        }

        /// <summary>
        /// Get the Unicode string at the current offset.
        /// </summary>
        /// <returns>String representation.</returns>
        public string GetStringFixedSize(ushort size)
        {
            return GetStringFixedSize(offset,size);
        }


        /// <summary>
        /// Put a string at the given index of the data.
        /// </summary>
        /// <param name="s">String to insert.</param>
        /// <param name="index">Index at which to insert.</param>
        public void PutString(string s,ushort index)
        {
            Global.Unicode.GetBytes(s).CopyTo(data, index);
            offset = (ushort)(index + s.Length * 2);
        }

        /// <summary>
        /// Put a string a the current offset.
        /// </summary>
        /// <param name="s">String to insert.</param>
        public void PutString(string s)
        {
            PutString(s, offset);
        }

        /// <summary>
        /// Get the byte at the given index.
        /// </summary>
        /// <param name="index">Index of the byte.</param>
        /// <returns>Byte at the index.</returns>
        public byte GetByte(ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + 1);
            return data[index];
        }

        /// <summary>
        /// Get the byte at the current offset.
        /// </summary>
        /// <returns>The byte.</returns>
        public byte GetByte()
        {
            return data[offset++];
        }

        /// <summary>
        /// Put the given byte at the given index.
        /// </summary>
        /// <param name="b">Byte to insert.</param>
        /// <param name="index">Index to insert at.</param>
        public void PutByte(byte b, ushort index)
        {
            data[index] = b;
            offset = (ushort) (index + 1);
        }

        /// <summary>
        /// Put the given byte at the current offset.
        /// </summary>
        /// <param name="b">Byte to insert.</param>
        public void PutByte(byte b)
        {
            data[offset++] = b;
        }

        /// <summary>
        /// Get the ushort at the given index.
        /// </summary>
        /// <param name="index">Index of the ushort.</param>
        /// <returns>The ushort value at the index.</returns>
        public ushort GetUShort(ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + 2);
            return BitConverter.ToUInt16(data, index);
        }

        /// <summary>
        /// Get the ushort at the current offset.
        /// </summary>
        /// <returns>The ushort value at the offset.</returns>
        public ushort GetUShort()
        {
            return GetUShort(offset);
        }

        /// <summary>
        /// Put the given ushort at the given index.
        /// </summary>
        /// <param name="s">Ushort to insert.</param>
        /// <param name="index">Index to insert at.</param>
        public void PutUShort(ushort s, ushort index)
        {
            BitConverter.GetBytes(s).CopyTo(data, index);
            offset = (ushort) (index + 2);
        }

        /// <summary>
        /// Put the given ushort at the current offset.
        /// </summary>
        /// <param name="s"></param>
        public void PutUShort(ushort s)
        {
            PutUShort(s,offset);
        }

        /// <summary>
        /// Get the short at the given index.
        /// </summary>
        /// <param name="index">Index of the short.</param>
        /// <returns>The short value at the index.</returns>
        public short GetShort(ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + 2);
            return BitConverter.ToInt16(data, index);
        }

        /// <summary>
        /// Get the short at the current offset.
        /// </summary>
        /// <returns>The short value at the offset.</returns>
        public short GetShort()
        {
            return GetShort(offset);
        }

        /// <summary>
        /// Put the given short at the given index.
        /// </summary>
        /// <param name="s">Short to insert.</param>
        /// <param name="index">Index to insert at.</param>
        public void PutShort(short s, ushort index)
        {
            BitConverter.GetBytes(s).CopyTo(data, index);
            offset = (ushort)(index + 2);
        }

        /// <summary>
        /// Put the given short at the current offset.
        /// </summary>
        /// <param name="s">Short to insert.</param>
        public void PutShort(short s)
        {
            PutShort(s,offset);
        }

        /// <summary>
        /// Get a set of bytes from a given location.
        /// </summary>
        /// <param name="count">Number of bytes to get.</param>
        /// <param name="index">Indec from where to get bytes.</param>
        /// <returns>Byte array.</returns>
        public byte[] GetBytes(ushort count, ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + count);
            byte[] retBytes = new byte[count];

            if (index + count <= this.data.Length)
            {
                for (ushort i = 0; i < count; i++)
                {
                    retBytes[i] = this.data[index + i];
                }
            }
            return retBytes;
        }

        /// <summary>
        /// Get a certain amount of bytes from the current offset.
        /// </summary>
        /// <param name="count">Number of bytes to read.</param>
        /// <returns>Byte array.</returns>
        public byte[] GetBytes(ushort count)
        {
            return GetBytes(offset, count);
        }

        /// <summary>
        /// Put some given bytes at a given position in the data array.
        /// </summary>
        /// <param name="bdata">bytes to add to the data array</param>
        /// <param name="index">position to add the bytes to</param>
        public void PutBytes(byte[] bdata, ushort index)
        {
            offset = (ushort)(index + bdata.Length);

            if (index + bdata.Length <= this.data.Length)
            {
                for (ushort i = 0; i < bdata.Length; i++)
                {
                    this.data[index + i] = bdata[i];
                }
            }
        }

        /// <summary>
        /// Put some given bytes at the current offset in the data array.
        /// </summary>
        /// <param name="bdata">bytes to add to the data array</param>
        public void PutBytes(byte[] bdata)
        {
            PutBytes(bdata,offset);
        }

        /// <summary>
        /// Get the int at the given index.
        /// </summary>
        /// <param name="index">Index of the int.</param>
        /// <returns>The int value at the index.</returns>
        public int GetInt(ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + 4);
            return BitConverter.ToInt32(data, index);
        }

        /// <summary>
        /// Get the int at the current offset.
        /// </summary>
        /// <returns>The int value at the offset.</returns>
        public int GetInt()
        {
            return GetInt(offset);
        }

        /// <summary>
        /// Put the given int at the given index.
        /// </summary>
        /// <param name="s">Int to insert.</param>
        /// <param name="index">Index to insert at.</param>
        public void PutInt(int s, ushort index)
        {
            BitConverter.GetBytes(s).CopyTo(data, index);
            offset = (ushort)(index + 4);
        }

        /// <summary>
        /// Put the given int at the current offset in the data.
        /// </summary>
        /// <param name="s">Int to insert.</param>
        public void PutInt(int s)
        {
            PutInt(s, offset);
        }


        /// <summary>
        /// Get the uint at the given index.
        /// </summary>
        /// <param name="index">Index of the uint.</param>
        /// <returns>The uint value at the index.</returns>
        public uint GetUInt(ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + 4);
            return BitConverter.ToUInt32(data, index);
        }

        /// <summary>
        /// Get the uint at the current offset.
        /// </summary>
        /// <returns>The uint value at the offset.</returns>
        public uint GetUInt()
        {
            return GetUInt(offset);
        }

        /// <summary>
        /// Put the given uint at the given index.
        /// </summary>
        /// <param name="s">uint to insert.</param>
        /// <param name="index">Index to insert at.</param>
        public void PutUInt(uint s, ushort index)
        {
            BitConverter.GetBytes(s).CopyTo(data, index);
            offset = (ushort)(index + 4);
        }

        /// <summary>
        /// Put the given uint at the current offset.
        /// </summary>
        /// <param name="s">uint to insert</param>
        public void PutUInt(uint s)
        {
            PutUInt(s,offset);
        }


        /// <summary>
        /// Get the float at the given index.
        /// </summary>
        /// <param name="index">Index of the float.</param>
        /// <returns>The float value at the index.</returns>
        public float GetFloat(ushort index)
        {
            if (!this.isGateway && index != 0) index += 4;
            offset = (ushort)(index + 4);

            return (float)((float)(BitConverter.ToInt32(data, index)) * 1.0e-3);   
        }

        /// <summary>
        /// Get the  float at the current offset.
        /// </summary>
        /// <returns>The float value at the offset.</returns>
        public float GetFloat()
        {
            return GetFloat(offset);
        }

        /// <summary>
        /// Put the given float at the given index.
        /// </summary>
        /// <param name="s">Float to insert.</param>
        /// <param name="index">Index to insert at.</param>
        public void PutFloat(float s, ushort index)
        {
            s *= 1.0e3f;

            BitConverter.GetBytes((uint)s).CopyTo(data, index);
            offset = (ushort)(index + 4);
        }

        /// <summary>
        /// Put the given float at the current offset in the data.
        /// </summary>
        /// <param name="s">Float to insert.</param>
        public void PutFloat(float s)
        {
            PutFloat(s, offset);
        }

        public void PutStandardItem(int id, uint u1, uint u2, string name, uint u3, byte clv, bool tradeable, ushort dura, byte stack, uint add1, uint add2, uint add3, byte itemindex, ushort index)
        {
            PutInt(id, (ushort)(index + 0));
            PutUInt(u1, (ushort)(index + 4)); // unknown
            PutUInt(u2, (ushort)(index + 8)); //unknown
            PutString(Global.SetStringLength(name, 16), (ushort)(index + 12));
            PutUInt(u3, (ushort)(index + 45)); // unknown
            PutByte(clv, (ushort)(index + 49));
            if (tradeable == false)
                PutByte(1, (ushort)(index + 50));
            else
                PutByte(0, (ushort)(index + 50));            
            PutUShort(dura, (ushort)(index + 51));
            PutByte(stack, (ushort)(index + 53));
            PutUInt(add1, (ushort)(index + 54));
            PutUInt(add2, (ushort)(index + 58));
            PutUInt(add3, (ushort)(index + 62));
            PutByte(itemindex, (ushort)(index + 66));

            offset = (ushort)(index + 67);
        }

        public void PutTradeItem(int id, uint u1, uint u2, string name, uint u3,byte clv, bool tradeable, ushort dura, byte stack, uint add1, uint add2, uint add3, ushort index)
        {
            PutInt(id, (ushort)(index + 0));
            PutUInt(u1, (ushort)(index + 4)); // unknown
            PutUInt(u2, (ushort)(index + 8)); //unknown
            PutString(Global.SetStringLength(name, 16), (ushort)(index + 12));
            PutUInt(u3, (ushort)(index + 45)); // unknown
            PutByte(clv, (ushort)(index + 49));
            if (tradeable == false)
                PutByte(1, (ushort)(index + 50));
            else
                PutByte(0, (ushort)(index + 50));
            PutUShort(dura, (ushort)(index + 51));
            PutByte(stack, (ushort)(index + 53));
            PutUInt(add1, (ushort)(index + 54));
            PutUInt(add2, (ushort)(index + 58));
            PutUInt(add3, (ushort)(index + 62));
            offset = (ushort)(index + 66);
        }
    }
            
}
