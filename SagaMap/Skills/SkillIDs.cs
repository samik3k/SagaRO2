using System;
using System.Collections.Generic;
using System.Text;

namespace SagaMap.Skills
{
    public enum SkillIDs
    {
        NormanBareHandAttack = 1,
        NormanShortSwordAttack = 101,
        NormanLongSwordAttack = 201,
        NormanSwordStickAttack = 301,
        NormanSwordStickAttack2 = 401,
        NormanDampflintAttack = 501,
        NormanDampflintAttack2 = 601,

        PromiseStone = 6001,

        #region "Novice"
        ShortSwordMastery = 1406901,
        ShortSwordMastery2 = 1406902,
        ShortSwordMastery3 = 1406903,
        ShortSwordMastery4 = 1406904,
        ShortSwordMastery5 = 1406905,
        ShortSwordMastery6 = 1406906,
        ShortSwordMastery7 = 1406907,
        ShortSwordMastery8 = 1406908,
        ShortSwordMastery9 = 1406909,
        ShortSwordMastery10 = 1406910,
        ShortSwordMastery11 = 1406911,        
        MartialArts = 1407001,
        MartialArts2 = 1407002,
        MartialArts3 = 1407003,
        MartialArts4 = 1407004,
        MartialArts5 = 1407005,
        MartialArts6 = 1407006,
        MartialArts7 = 1407007,
        MartialArts8 = 1407008,
        MartialArts9 = 1407009,
        MartialArts10 = 1407010,
        MartialArts11 = 1407011,
        MartialArts12 = 1407012,
        MartialArts13 = 1407013,
        MartialArts14 = 1407014,
        MartialArts15 = 1407015,
        MartialArts16 = 1407016,
        
        Tension = 1407101,
        Tension2 = 1407102,
        Tension3 = 1407103,
        Tension4 = 1407104,
        Tension5 = 1407105,
        Tension6 = 1407106,
        Tension7 = 1407107,
        Tension8 = 1407108,
        Tension9 = 1407109,
        Tension10 = 1407110,
        Integritas = 1407201,
        Integritas2 = 1407202,
        Integritas3 = 1407203,
        Integritas4 = 1407204,
        Integritas5 = 1407205,
        Integritas6 = 1407206,
        Integritas7 = 1407207,
        Integritas8 = 1407208,
        Integritas9 = 1407209,
        Integritas10 = 1407210,    
        ChakraaBreath = 1407301,
        QuickBlow = 1407401,
        QuickBlow2 = 1407402,
        QuickBlow3 = 1407403,
        QuickBlow4 = 1407404,
        QuickBlow5 = 1407405,
        QuickBlow6 = 1407406,
        QuickBlow7 = 1407407,
        QuickBlow8 = 1407408,
        QuickBlow9 = 1407409,
        QuickBlow10 = 1407410,
        QuickBlow11 = 1407411,
        QuickBlow12 = 1407412,
        QuickBlow13 = 1407413,
        QuickBlow14 = 1407414,
        QuickBlow15 = 1407415,
        QuickBlow16 = 1407416,
        QuickBlow17 = 1407417,
        QuickBlow18 = 1407418,
        QuickBlow19 = 1407419,
        QuickBlow20 = 1407420,
        ImprovedCombo = 1407501,
        ImprovedCombo2 = 1407502,
        ImprovedCombo3 = 1407503,
        ImprovedCombo4 = 1407504,
        ImprovedCombo5 = 1407505,
        ImprovedCombo6 = 1407506,
        ImprovedCombo7 = 1407507,
        ImprovedCombo8 = 1407508,
        ImprovedCombo9 = 1407509,
        ImprovedCombo10 = 1407510,
        ImprovedCombo11 = 1407511,
        InsightStrike = 1407601,
        InsightStrike1 = 1407602,
        InsightStrike2 = 1407603,
        InsightStrike3 = 1407604,
        InsightStrike4 = 1407605,
        InsightStrike5 = 1407606,
        InsightStrike6 = 1407607,
        InsightStrike7 = 1407608,
        InsightStrike8 = 1407609,
        InsightStrike9 = 1407610,
        InsightStrike10 = 1407611,
        PowerStrike = 1407701,
        PowerStrike2 = 1407702,
        PowerStrike3 = 1407703,
        PowerStrike4 = 1407704,
        PowerStrike5 = 1407705,
        PowerStrike6 = 1407706,
        PowerStrike7 = 1407707,
        PowerStrike8 = 1407708,
        PowerStrike9 = 1407709,
        PowerStrike10 = 1407710,        
        AppealSympathy = 1407801,
        AppealSympathy2 = 1407802,
        AppealSympathy3 = 1407803,
        AppealSympathy4 = 1407804,
        AppealSympathy5 = 1407805,
        AppealSympathy6 = 1407806,
        AppealSympathy7 = 1407807,
        AppealSympathy8 = 1407808,
        AppealSympathy9 = 1407809,
        AppealSympathy10 = 1407810,
        ActDead = 1407901,
        ActDead2 = 1407902,
        ActDead3 = 1407903,
        ActDead4 = 1407904,
        ActDead5 = 1407905,
        ActDead6 = 1407906,
        ActDead7 = 1407907,
        ActDead8 = 1407908,
        ActDead9 = 1407909,
        ActDead10 = 1407910,
        WhiteShortSwordMastery = 1408001,
        WhiteShortSwordMastery2 = 1408002,
        WhiteShortSwordMastery3 = 1408003,
        WhiteShortSwordMastery4 = 1408004,
        WhiteShortSwordMastery5 = 1408005,
        WhiteShortSwordMastery6 = 1408006,
        WhiteShortSwordMastery7 = 1408007,
        WhiteShortSwordMastery8 = 1408008,
        WhiteShortSwordMastery9 = 1408009,
        WhiteShortSwordMastery10 = 1408010,
        WhiteShortSwordMastery11 = 1408011,

        #endregion

        #region "Swordman"

        LongSwordMastery = 1416901,
        LongSwordMastery2 = 1416902,
        LongSwordMastery3 = 1416903,
        LongSwordMastery4 = 1416904,
        LongSwordMastery5 = 1416905,
        LongSwordMastery6 = 1416906,
        LongSwordMastery7 = 1416907,
        LongSwordMastery8 = 1416908,
        LongSwordMastery9 = 1416909,
        LongSwordMastery10 = 1416910,
        LongSwordMastery11 = 1416911,
        ArtOfWarrior = 1419101,
        ArtOfWarrior2 = 1419102,
        ArtOfWarrior3 = 1419103,
        ArtOfWarrior4 = 1419104,
        ArtOfWarrior5 = 1419105,
        ArtOfWarrior6 = 1419106,
        ArtOfWarrior7 = 1419107,
        ArtOfWarrior8 = 1419108,
        ArtOfWarrior9 = 1419109,
        ArtOfWarrior10 = 1419110,
        ArtOfWarrior11 = 1419111,
        DefenceMastery = 1417001,
        DefenceMastery2 = 1417002,
        DefenceMastery3 = 1417003,
        DefenceMastery4 = 1417004,
        DefenceMastery5 = 1417005,
        DefenceMastery6 = 1417006,
        DefenceMastery7 = 1417007,
        DefenceMastery8 = 1417008,
        DefenceMastery9 = 1417009,
        DefenceMastery10 = 1417010,
        DefenceMastery11 = 1417011,
        StrengthenRecovery = 1417101,
        StrengthenRecovery2 = 1417102,
        StrengthenRecovery3 = 1417103,
        StrengthenRecovery4 = 1417104,
        StrengthenRecovery5 = 1417105,
        StrengthenRecovery6 = 1417106,
        Provoke = 1417601,
        Provoke2 = 1417602,
        Provoke3 = 1417603,
        Provoke4 = 1417604,
        Provoke5 = 1417605,
        Provoke6 = 1417606,
        Provoke7 = 1417607,
        Provoke8 = 1417608,
        Provoke9 = 1417609,
        Provoke10 = 1417610,
        QuickenAttack = 1417701,
        QuickenAttack2 = 1417702,
        QuickenAttack3 = 1417703,
        QuickenAttack4 = 1417704,
        QuickenAttack5 = 1417705,
        MockingBlow = 1417801,
        MockingBlow2 = 1417802,
        MockingBlow3 = 1417803,
        MockingBlow4 = 1417804,
        MockingBlow5 = 1417805,
        MockingBlow6 = 1417806,
        DefensiveStance = 1417901,
        DefensiveStance2 = 1417902,
        AdvancedDefensiveStance = 1417903,
        InternalInjury = 1418001,
        InternalInjury2 = 1418002,
        InternalInjury3 = 1418003,
        InternalInjury4 = 1418004,
        InternalInjury5 = 1418005,
        InternalInjury6 = 1418006,
        InternalInjury7 = 1418007,
        InternalInjury8 = 1418008,
        InternalInjury9 = 1418009,
        InternalInjury10 = 1418010,
        InternalInjury11 = 1418011,
        CourageousAssault = 1418101,
        CourageousAssault2 = 1418102,
        CourageousAssault3 = 1418103,
        CourageousAssault4 = 1418104,
        CourageousAssault5 = 1418105,
        CourageousAssault6 = 1418106,
        CourageousAssault7 = 1418107,
        CourageousAssault8 = 1418108,
        CourageousAssault9 = 1418109,
        CourageousAssault10 = 1418110,
        CourageousAssault11 = 1418111,
        ChargeAttack = 1418401,
        ChargeAttack2 = 1418402,
        ChargeAttack3 = 1418403,
        ChargeAttack4 = 1418404,
        ChargeAttack5 = 1418405,
        ChargeAttack6 = 1418406,
        ChargeAttack7 = 1418407,
        ChargeAttack8 = 1418408,
        ChargeAttack9 = 1418409,
        ChargeAttack10 = 1418410,
        ChargeAttack11 = 1418411,
        MagnumBreak = 1418501,
        MagnumBreak2 = 1418502,
        MagnumBreak3 = 1418503,
        MagnumBreak4 = 1418504,
        MagnumBreak5 = 1418505,
        MagnumBreak6 = 1418506,
        MagnumBreak7 = 1418507,
        MagnumBreak8 = 1418508,
        MagnumBreak9 = 1418509,
        MagnumBreak10 = 1418510,
        MagnumBreak11 = 1418511,
        Poking = 1418601,
        Poking2 = 1418602,
        Poking3 = 1418603,
        Poking4 = 1418604,
        Poking5 = 1418605,
        ShieldCharge = 1418701,
        ShieldCharge2 = 1418702,
        ShieldCharge3 = 1418703,
        ShieldCharge4 = 1418704,
        ShieldCharge5 = 1418705,
        ShieldCharge6 = 1418706,
        ShieldCharge7 = 1418707,
        ShieldCharge8 = 1418708,
        ShieldCharge9 = 1418709,
        ShieldCharge10 = 1418710,
        ShieldCharge11 = 1418711,
        ShieldBlock = 1418901,
        ShieldBlock2 = 1418902,
        ShieldBlock3 = 1418903,
        ShieldBlock4 = 1418904,
        ShieldBlock5 = 1418905,
        ShieldBlock6 = 1418906,
        ShieldBlock7 = 1418907,
        ShieldBlock8 = 1418908,
        ShieldBlock9 = 1418909,
        ShieldBlock10 = 1418910,
        ShieldBlock11 = 1418911,

        #endregion

        #region "Recruit"

        DampRifleMastery = 1426901,
        DampRifleMastery2 = 1426902,
        DampRifleMastery3 = 1426903,
        DampRifleMastery4 = 1426904,
        DampRifleMastery5 = 1426905,
        DampRifleMastery6 = 1426906,
        DampRifleMastery7 = 1426907,
        DampRifleMastery8 = 1426908,
        DampRifleMastery9 = 1426909,
        DampRifleMastery10 = 1426910,
        DampRifleMastery11 = 1426911,
        CloseOrderDrill = 1427001,
        CloseOrderDrill2 = 1427002,
        CloseOrderDrill3 = 1427003,
        CloseOrderDrill4 = 1427004,
        CloseOrderDrill5 = 1427005,
        CloseOrderDrill6 = 1427006,
        CloseOrderDrill7 = 1427007,
        CloseOrderDrill8 = 1427008,
        CloseOrderDrill9 = 1427009,
        CloseOrderDrill10 = 1427010,
        CloseOrderDrill11 = 1427011,
        StrongMind = 1427101,
        StrongMind2 = 1427102,
        StrongMind3 = 1427103,
        StrongMind4 = 1427104,
        StrongMind5 = 1427105,
        StrongMind6 = 1427106,
        StrongMind7 = 1427107,
        StrongMind8 = 1427108,
        StrongMind9 = 1427109,
        StrongMind10 = 1427110,
        StrongMind11 = 1427111,
        StrongMind12 = 1427112,
        StrongMind13 = 1427113,
        StrongMind14 = 1427114,
        StrongMind15 = 1427115,
        PredatorFocus = 1427301,
        PredatorFocus2 = 1427302,
        PredatorFocus3 = 1427303,
        PredatorFocus4 = 1427304,
        PredatorFocus5 = 1427305,
        PredatorFocus6 = 1427306,
        PredatorFocus7 = 1427307,
        PredatorFocus8 = 1427308,
        PredatorFocus9 = 1427309,
        PredatorFocus10 = 1427310,
        PredatorFocus11 = 1427311,
        PredatorFocus12 = 1427312,
        PredatorFocus13 = 1427313,
        PredatorFocus14 = 1427314,
        PredatorFocus15 = 1427315,
        Tracking = 1427501,
        Tracking2 = 1427502,
        Tracking3 = 1427503,
        Tracking4 = 1427504,
        Tracking5 = 1427505,
        Tracking6 = 1427506,
        Tracking7 = 1427507,
        Tracking8 = 1427508,
        Tracking9 = 1427509,
        Tracking10 = 1427510,
        Designation = 1427601,
        Designation2 = 1427602,
        Designation3 = 1427603,
        Designation4 = 1427604,
        Designation5 = 1427605,
        Designation6 = 1427606,
        Designation7 = 1427607,
        Designation8 = 1427608,
        Designation9 = 1427609,
        Designation10 = 1427610,
        Designation11 = 1427611,
        FreezingShot = 1427701,
        FreezingShot2 = 1427702,
        FreezingShot3 = 1427703,
        FreezingShot4 = 1427704,
        FreezingShot5 = 1427705,
        FreezingShot6 = 1427706,
        FreezingShot7 = 1427707,
        FreezingShot8 = 1427708,
        FreezingShot9 = 1427709,
        FreezingShot10 = 1427710,
        FreezingShot11 = 1427711,
        LuringShot = 1427801,
        LuringShot2 = 1427802,
        LuringShot3 = 1427803,
        LuringShot4 = 1427804,
        LuringShot5 = 1427805,
        LuringShot6 = 1427806,
        LuringShot7 = 1427807,
        LuringShot8 = 1427808,
        LuringShot9 = 1427809,
        LuringShot10 = 1427810,
        PiercingShot = 1427901,
        PiercingShot2 = 1427902,
        PiercingShot3 = 1427903,
        PiercingShot4 = 1427904,
        PiercingShot5 = 1427905,
        PiercingShot6 = 1427906,
        PiercingShot7 = 1427907,
        PiercingShot8 = 1427908,
        PiercingShot9 = 1427909,
        PiercingShot10 = 1427910,
        RotatingFireShot = 1428001,
        RotatingFireShot2 = 1428002,
        RotatingFireShot3 = 1428003,
        RotatingFireShot4 = 1428004,
        RotatingFireShot5 = 1428005,
        RotatingFireShot6 = 1428006,
        AimingShot = 1428101,
        AimingShot2 = 1428102,
        AimingShot3 = 1428103,
        AimingShot4 = 1428104,
        AimingShot5 = 1428105,
        AimingShot6 = 1428106,
        Disarm = 1428201,
        Disarm2 = 1428202,
        Disarm3 = 1428203,
        Disarm4 = 1428204,
        Disarm5 = 1428205,
        Disarm6 = 1428206,
        Disarm7 = 1428207,
        Disarm8 = 1428208,
        Disarm9 = 1428209,
        Disarm10 = 1428210,
        Disarm11 = 1428211,
        Disarm12 = 1428212,
        Disarm13 = 1428213,
        Disarm14 = 1428214,
        Disarm15 = 1428215,
        FocusShot = 1428401,
        FocusShot2 = 1428402,
        FocusShot3 = 1428403,
        FocusShot4 = 1428404,
        FocusShot5 = 1428405,
        FocusShot6 = 1428406,
        FocusShot7 = 1428407,
        FocusShot8 = 1428408,
        FocusShot9 = 1428409,
        FocusShot10 = 1428410,
        BayonetStance = 1428301,
        BayonetStance2 = 1428302,
        AdvancedBayonetStance = 1428303,
        FlinteSlam = 1428801,
        FlinteSlam2 = 1428802,
        FlinteSlam3 = 1428803,
        FlinteSlam4 = 1428804,
        FlinteSlam5 = 1428805,
        FlinteSlam6 = 1428806,
        FlinteSlam7 = 1428807,
        FlinteSlam8 = 1428808,
        FlinteSlam9 = 1428809,
        FlinteSlam10 = 1428810,
        FlinteSlam11 = 1428811,
        FlinteSlam12 = 1428812,
        FlinteSlam13 = 1428813,
        FlinteSlam14 = 1428814,
        FlinteSlam15 = 1428815,
        PolleoShot = 1428901,
        PolleoShot2 = 1428902,
        PolleoShot3 = 1428903,
        PolleoShot4 = 1428904,
        PolleoShot5 = 1428905,
        PolleoShot6 = 1428906,
        PolleoShot7 = 1428907,
        PolleoShot8 = 1428908,
        PolleoShot9 = 1428909,
        PolleoShot10 = 1428910,
        PolleoShot11 = 1428911,
        FinalBlow = 1429001,
        FinalBlow2 = 1429002,
        FinalBlow3 = 1429003,
        FinalBlow4 = 1429004,
        FinalBlow5 = 1429005,
        FinalBlow6 = 1429006,
        FinalBlow7 = 1429007,
        FinalBlow8 = 1429008,
        FinalBlow9 = 1429009,
        FinalBlow10 = 1429010,

        FirePractice = 1429101,
        FirePractice2 = 1429102,
        FirePractice3 = 1429103,
        FirePractice4 = 1429104,
        FirePractice5 = 1429105,
        FirePractice6 = 1429106,
        FirePractice7 = 1429107,
        FirePractice8 = 1429108,
        FirePractice9 = 1429109,
        FirePractice10 = 1429110,
        FirePractice11 = 1429111,
        
        #endregion

        #region "Thief"
        SharpenedBlades = 1437001,
        SharpenedBlades2 = 1437002,
        SharpenedBlades3 = 1437003,
        SharpenedBlades4 = 1437004,
        SharpenedBlades5 = 1437005,
        SharpenedBlades6 = 1437006,
        SharpenedBlades7 = 1437007,
        SharpenedBlades8 = 1437008,
        SharpenedBlades9 = 1437009,
        SharpenedBlades10 = 1437010,
        SharpenedBlades11 = 1437011,
        FatalContract = 1437101,
        FatalContract2 = 1437102,
        FatalContract3 = 1437103,
        FatalContract4 = 1437104,
        FatalContract5 = 1437105,
        FatalContract6 = 1437106,
        FatalContract7 = 1437107,
        FatalContract8 = 1437108,
        FatalContract9 = 1437109,
        FatalContract10 = 1437110,
        FatalContract11 = 1437111,        
        VenomCoat = 1457401,
        VenomCoat2 = 1457402,
        VenomCoat3 = 1457403,
        VenomCoat4 = 1457404,
        VenomCoat5 = 1457405,
        VenomCoat6 = 1457406,
        ShadowStep = 1437201,
        ShadowStep2 = 1437202,
        ShadowStep3 = 1437203,
        ShadowStep4 = 1437204,
        ShadowStep5 = 1437205,
        ShadowStep6 = 1437206,
        ShadowStep7 = 1437207,
        ShadowStep8 = 1437208,
        ShadowStep9 = 1437209,
        ShadowStep10 = 1437210,
        ShadowStep11 = 1437211,
        Disguise = 1435101,
        Disguise2 = 1435102,
        Disguise3 = 1435103,
        Disguise4 = 1435104,
        Disguise5 = 1435105,
        Disguise6 = 1435106,
        Disguise7 = 1435107,
        Disguise8 = 1435108,
        Disguise9 = 1435109,
        Disguise10 = 1435110,
        Disguise11 = 1435111,
        RapidRun = 1437701,
        RapidRun2 = 1437702,
        RapidRun3 = 1437703,
        RapidRun4 = 1437704,
        RapidRun5 = 1437705,
        RapidRun6 = 1437706,
        RapidRun7 = 1437707,
        RapidRun8 = 1437708,
        RapidRun9 = 1437709,
        RapidRun10 = 1437710,
        ArmorSmash = 1437801,
        ArmorSmash2 = 1437802,
        ArmorSmash3 = 1437803,
        ArmorSmash4 = 1437804,
        ArmorSmash5 = 1437805,
        StripArmor = 1437901,
        StripArmor2 = 1437902,
        StripArmor3 = 1437903,
        StripArmor4 = 1437904,
        StripArmor5 = 1437905,
        StripArmor6 = 1437906,
        StripArmor7 = 1437907,
        StripArmor8 = 1437908,
        StripArmor9 = 1437909,
        StripArmor10 = 1437910,
        StripArmor11 = 1437911,
        ManhoodBreaker = 1438001,
        ManhoodBreaker2 = 1438002,
        ManhoodBreaker3 = 1438003,
        ManhoodBreaker4 = 1438004,
        ManhoodBreaker5 = 1438005,
        ManhoodBreaker6 = 1438006,

        #endregion

        #region "Enchanter"
        SwordStick = 1446901,
        SwordStick2 = 1446902,
        SwordStick3 = 1446903,
        SwordStick4 = 1446904,
        SwordStick5 = 1446905,
        SwordStick6 = 1446906,
        SwordStick7 = 1446907,
        SwordStick8 = 1446908,
        SwordStick9 = 1446909,
        SwordStick10 = 1446910,
        SwordStick11 = 1446911,
        MentalTraining = 1447001,
        MentalTraining2 = 1447002,
        MentalTraining3 = 1447003,
        MentalTraining4 = 1447004,
        MentalTraining5 = 1447005,
        MentalTraining6 = 1447006,
        MentalTraining7 = 1447007,
        MentalTraining8 = 1447008,
        MentalTraining9 = 1447009,
        MentalTraining10 = 1447010,
        MentalTraining11 = 1447011,
        Meditation = 1447101,
        Meditation2 = 1447102,
        Meditation3 = 1447103,
        Meditation4 = 1447104,
        Meditation5 = 1447105,
        MentalPower = 1447201,
        MentalPower2 = 1447202,
        MentalPower3 = 1447203,
        MentalPower4 = 1447204,
        MentalPower5 = 1447205,
        MentalPower6 = 1447206,
        MentalPower7 = 1447207,
        MentalPower8 = 1447208,
        MentalPower9 = 1447209,
        MentalPower10 = 1447210,
        MentalPower11 = 1447211,
        SoulResistance = 1447301,
        SoulResistance2 = 1447302,
        SoulResistance3 = 1447303,
        SoulResistance4 = 1447304,
        SoulResistance5 = 1447305,
        SoulResistance6 = 1447306,
        SoulResistance7 = 1447307,
        SoulResistance8 = 1447308,
        SoulResistance9 = 1447309,
        SoulResistance10 = 1447310,
        SoulResistance11 = 1447311,
        EnergyCoat = 1447401,
        EnergyCoat2 = 1447402,
        EnergyCoat3 = 1447403,
        EnergyCoat4 = 1447404,
        EnergyCoat5 = 1447405,
        EnergyCoat6 = 1447406,
        EnergyCoat7 = 1447407,
        EnergyCoat8 = 1447408,
        EnergyCoat9 = 1447409,
        EnergyCoat10 = 1447410,
        EnergyCoat11 = 1447411,
        Memorize = 1447501,
        Memorize2 = 1447502,
        Memorize3 = 1447503,
        Memorize4 = 1447504,
        Memorize5 = 1447505,
        Memorize6 = 1447506,
        Memorize7 = 1447507,
        Memorize8 = 1447508,
        Memorize9 = 1447509,
        Memorize10 = 1447510,
        Heal = 1447601,
        Heal2 = 1447602,
        Heal3 = 1447603,
        Heal4 = 1447604,
        Heal5 = 1447605,
        Heal6 = 1447606,
        Heal7 = 1447607,
        Heal8 = 1447608,
        Heal9 = 1447609,
        Heal10 = 1447610,
        Heal11 = 1447611,
        Recovery = 1447701,
        Recovery2 = 1447702,
        Recovery3 = 1447703,
        Recovery4 = 1447704,
        Recovery5 = 1447705,
        SoulPurification = 1447801,
        SoulPurification2 = 1447801,
        SoulPurification3 = 1447801,
        SoulPurification4 = 1447801,
        SoulPurification5 = 1447801,
        WeaponBlessing = 1447901,
        WeaponBlessing2 = 1447902,
        WeaponBlessing3 = 1447903,
        WeaponBlessing4 = 1447904,
        WeaponBlessing5 = 1447905,
        WeaponBlessing6 = 1447906,
        ArmorBlessing = 1448001,
        ArmorBlessing2 = 1448002,
        ArmorBlessing3 = 1448003,
        ArmorBlessing4 = 1448004,
        ArmorBlessing5 = 1448005,
        ArmorBlessing6 = 1448006,
        FireResistance = 1448101,
        FireResistance2 = 1448102,
        FireResistance3 = 1448103,
        FireResistance4 = 1448104,
        FireResistance5 = 1448105,
        FireResistance6 = 1448106,
        FireResistance7 = 1448107,
        FireResistance8 = 1448108,
        FireResistance9 = 1448109,
        FireResistance10 = 1448110,
        FireResistance11 = 1448111,
        IceResistance = 1448201,
        IceResistance2 = 1448202,
        IceResistance3 = 1448203,
        IceResistance4 = 1448204,
        IceResistance5 = 1448205,
        IceResistance6 = 1448206,
        IceResistance7 = 1448207,
        IceResistance8 = 1448208,
        IceResistance9 = 1448209,
        IceResistance10 = 1448210,
        IceResistance11 = 1448211,
        LightningResistance = 1448301,
        LightningResistance2 = 1448302,
        LightningResistance3 = 1448303,
        LightningResistance4 = 1448304,
        LightningResistance5 = 1448305,
        LightningResistance6 = 1448306,
        LightningResistance7 = 1448307,
        LightningResistance8 = 1448308,
        LightningResistance9 = 1448309,
        LightningResistance10 = 1448310,
        LightningResistance11 = 1448311,
        FireBolt = 1448401,
        FireBolt2 = 1448402,
        FireBolt3 = 1448403,
        FireBolt4 = 1448404,
        FireBolt5 = 1448405,
        FireBolt6 = 1448406,
        FireBolt7 = 1448407,
        FireBolt8 = 1448408,
        FireBolt9 = 1448409,
        FireBolt10 = 1448410,
        FireBolt11 = 1448411,
        IceBolt = 1448601,
        IceBolt2 = 1448602,
        IceBolt3 = 1448603,
        IceBolt4 = 1448604,
        IceBolt5 = 1448605,
        IceBolt6 = 1448606,
        IceBolt7 = 1448607,
        IceBolt8 = 1448608,
        IceBolt9 = 1448609,
        IceBolt10 = 1448610,
        IceBolt11 = 1448611,
        SummonLightning = 1448701,
        SummonLightning2 = 1448702,
        SummonLightning3 = 1448703,
        SummonLightning4 = 1448704,
        SummonLightning5 = 1448705,
        SummonLightning6 = 1448706,
        SummonLightning7 = 1448707,
        SummonLightning8 = 1448708,
        SummonLightning9 = 1448709,
        SummonLightning10 = 1448710,
        SummonLightning11 = 1448711,
        Tempestas = 1448801,
        Tempestas2 = 1448802,
        Tempestas3 = 1448803,
        Tempestas4 = 1448804,
        Tempestas5 = 1448805,
        Tempestas6 = 1448806,
        Tempestas7 = 1448807,
        Tempestas8 = 1448808,
        Tempestas9 = 1448809,
        Tempestas10 = 1448810,
        Tempestas11 = 1448811,
        ThorsRabies = 1448901,
        ThorsRabies2 = 1448902,
        ThorsRabies3 = 1448903,
        ThorsRabies4 = 1448904,
        ThorsRabies5 = 1448905,
        ThorsRabies6 = 1448906,
        ThorsRabies7 = 1448907,
        ThorsRabies8 = 1448908,
        ThorsRabies9 = 1448909,
        ThorsRabies10 = 1448910,
        ThorsRabies11 = 1448911,
        SwordstickStance = 1448501,
        SwordstickStance2 = 1448502,
        AdvancedSwordstickStance = 1448503,
        Prospect = 1449001,
        Prospect2 = 1449002,
        Prospect3 = 1449003,
        Prospect4 = 1449004,
        Prospect5 = 1449005,
        Prospect6 = 1449006,
        Prospect7 = 1449007,
        Prospect8 = 1449008,
        Prospect9 = 1449009,
        Prospect10 = 1449010,
        SummonPuppet = 1449101,
        SummonPuppet2 = 1449102,
        SummonPuppet3 = 1449103,
        SummonPuppet4 = 1449104,
        SummonPuppet5 = 1449105,
        ShadowStrike = 1449201,
        ShadowStrike2 = 1449202,
        ShadowStrike3 = 1449203,
        ShadowStrike4 = 1449204,
        ShadowStrike5 = 1449205,
        ForcefullBlow = 1449301,
        ForcefullBlow2 = 1449302,
        ForcefullBlow3 = 1449303,
        ForcefullBlow4 = 1449304,
        ForcefullBlow5 = 1449305,
        ForcefullBlow6 = 1449306,
        SinisterStrike = 1449401,
        SinisterStrike2 = 1449402,
        SinisterStrike3 = 1449403,
        SinisterStrike4 = 1449404,
        SinisterStrike5 = 1449405,
        SwordOfIce = 1449501,
        SwordOfIce2 = 1449502,
        SwordOfIce3 = 1449503,
        SwordOfIce4 = 1449504,
        SwordOfIce5 = 1449505,
        SwordOfIce6 = 1449506,
        SwordOfIce7 = 1449507,
        SwordOfIce8 = 1449508,
        SwordOfIce9 = 1449509,
        SwordOfIce10 = 1449510,
        SwordOfIce11 = 1449511,
        LifeLeech = 1449601,
        LifeLeech2 = 1449602,
        LifeLeech3 = 1449603,
        LifeLeech4 = 1449604,
        LifeLeech5 = 1449605,
        LifeLeech6 = 1449606,
        LifeLeech7 = 1449607,
        LifeLeech8 = 1449608,
        LifeLeech9 = 1449609,
        LifeLeech10 = 1449610,
        LifeLeech11 = 1449611,
#endregion


        OpenBox = 700101,
        RedPotion = 400001,
        RedPotion2 = 400002,
        RedPotion3 = 400003,

    }
    
}
