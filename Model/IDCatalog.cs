﻿using System.Collections.Generic;

namespace ESO_Lang_Editor.Model
{
    class IDCatalog
    {
        private Dictionary<string, string> fileidToCategory;

        public IDCatalog()
        {
            InitFileidToCategory();
        }

        public string GetCategory(string fileid)
        {
            if (fileidToCategory.ContainsKey(fileid))
            {
                string category = fileidToCategory[fileid];
                return category;
            }
            return "";
        }

        private void InitFileidToCategory()
        {
            fileidToCategory = new Dictionary<string, string>();

            //fileidToCategory.Add("UI", "UI");
            fileidToCategory.Add("12529189", "成就名");
            fileidToCategory.Add("188155806", "成就总体目标");
            fileidToCategory.Add("172030117", "成就分项目标");
            fileidToCategory.Add("51188213", "书籍信件名");
            fileidToCategory.Add("21337012", "书籍信件内容");
            fileidToCategory.Add("78205445", "聊天预置语句");
            fileidToCategory.Add("121778053", "聊天预置语句");
            fileidToCategory.Add("208337109", "染色名");
            fileidToCategory.Add("152988005", "国家与地区名");
            fileidToCategory.Add("124362421", "皇冠宝箱名");
            fileidToCategory.Add("249673710", "皇冠宝箱描述");
            fileidToCategory.Add("70328405", "皇冠物品名");
            fileidToCategory.Add("263796174", "皇冠物品描述");
            fileidToCategory.Add("75236676", "NPC打招呼");
            fileidToCategory.Add("75237444", "NPC打招呼2");
            fileidToCategory.Add("75238212", "NPC打招呼3");
            fileidToCategory.Add("75240772", "NPC打招呼4");
            fileidToCategory.Add("75241540", "NPC打招呼5");
            fileidToCategory.Add("75242308", "NPC打招呼6");
            fileidToCategory.Add("75244868", "greeting");
            fileidToCategory.Add("75245636", "greeting");
            fileidToCategory.Add("75246404", "greeting");
            fileidToCategory.Add("75248964", "greeting");
            fileidToCategory.Add("75249732", "greeting");
            fileidToCategory.Add("75250500", "greeting");
            fileidToCategory.Add("75253060", "greeting");
            fileidToCategory.Add("75253828", "greeting");
            fileidToCategory.Add("75254596", "greeting");
            fileidToCategory.Add("75257156", "greeting");
            fileidToCategory.Add("75257924", "greeting");
            fileidToCategory.Add("75258692", "greeting");
            fileidToCategory.Add("75261252", "greeting");
            fileidToCategory.Add("75262020", "greeting");
            fileidToCategory.Add("75262788", "greeting");
            fileidToCategory.Add("75265348", "greeting");
            fileidToCategory.Add("75266116", "greeting");
            fileidToCategory.Add("75266884", "greeting");
            fileidToCategory.Add("99155012", "greeting");
            fileidToCategory.Add("149979604", "greeting");
            fileidToCategory.Add("149983700", "greeting");
            fileidToCategory.Add("149987796", "greeting");
            fileidToCategory.Add("149991892", "greeting");
            fileidToCategory.Add("149995988", "greeting");
            fileidToCategory.Add("150000084", "greeting");
            fileidToCategory.Add("150004180", "greeting");
            fileidToCategory.Add("150008276", "greeting");
            fileidToCategory.Add("150045140", "greeting");
            fileidToCategory.Add("150049236", "greeting");
            fileidToCategory.Add("150053332", "greeting");
            fileidToCategory.Add("150057428", "greeting");
            fileidToCategory.Add("150061524", "greeting");
            fileidToCategory.Add("150065620", "greeting");
            fileidToCategory.Add("150069716", "greeting");
            fileidToCategory.Add("150073812", "greeting");
            fileidToCategory.Add("150525940", "greeting");
            fileidToCategory.Add("150962644", "greeting");
            fileidToCategory.Add("150966740", "greeting");
            fileidToCategory.Add("150970836", "greeting");
            fileidToCategory.Add("150974932", "greeting");
            fileidToCategory.Add("150979028", "greeting");
            fileidToCategory.Add("150983124", "greeting");
            fileidToCategory.Add("150987220", "greeting");
            fileidToCategory.Add("150991316", "greeting");
            fileidToCategory.Add("169602884", "greeting");
            fileidToCategory.Add("259945604", "greeting");
            fileidToCategory.Add("3427285", "表情预览");
            fileidToCategory.Add("6658117", "交互(解锁)");
            fileidToCategory.Add("8158238", "交互(场景物品)");
            fileidToCategory.Add("12320021", "交互(背包内物品)");
            fileidToCategory.Add("12912341", "交互(场景NPC与物品)");
            fileidToCategory.Add("34717246", "交互(重物品)");
            fileidToCategory.Add("45275092", "交互(合上书籍)");
            fileidToCategory.Add("70307621", "交互(场景物品)");
            fileidToCategory.Add("74865733", "交互(场景物品)");
            fileidToCategory.Add("108533454", "交互(交互中)");
            fileidToCategory.Add("109216308", "交互(离开交互)");
            fileidToCategory.Add("139475237", "收藏品-表情");
            fileidToCategory.Add("188095652", "交互(未知)");
            fileidToCategory.Add("219689294", "交互(场景魔法物品？)");
            fileidToCategory.Add("263004526", "交互(交互中)2");
            fileidToCategory.Add("149328292", "interact-win");
            fileidToCategory.Add("242841733", "装备物品名");
            fileidToCategory.Add("228378404", "装备物品描述");
            fileidToCategory.Add("11547061", "item-type");
            fileidToCategory.Add("33378341", "item-type");
            fileidToCategory.Add("41262789", "item-type");
            fileidToCategory.Add("41983653", "item-type");
            fileidToCategory.Add("52856117", "item-type");
            fileidToCategory.Add("59621621", "item-type");
            fileidToCategory.Add("61533042", "item-type");
            fileidToCategory.Add("98383029", "item-type");
            fileidToCategory.Add("68494373", "item-type");
            fileidToCategory.Add("124119973", "item-type");
            fileidToCategory.Add("214390738", "item-type");
            fileidToCategory.Add("217370677", "item-type");
            fileidToCategory.Add("52420949", "日志任务名");
            fileidToCategory.Add("265851556", "日志任务描述");
            fileidToCategory.Add("219317028", "letter");
            fileidToCategory.Add("162658389", "载屏地图名");
            fileidToCategory.Add("70901198", "载屏描述");
            fileidToCategory.Add("200374766", "载屏描述2");
            fileidToCategory.Add("169578494", "房屋载屏描述");
            fileidToCategory.Add("19709733", "location-and-object");
            fileidToCategory.Add("146361138", "location-and-object");
            fileidToCategory.Add("157886597", "location-and-object");
            fileidToCategory.Add("162946485", "location-and-object");
            fileidToCategory.Add("164009093", "location-and-object");
            fileidToCategory.Add("19398485", "location-and-object");
            fileidToCategory.Add("211899940", "location-and-object");
            fileidToCategory.Add("219936053", "location-and-object");
            fileidToCategory.Add("247934532", "location-and-object");
            fileidToCategory.Add("260523861", "location-and-object");
            fileidToCategory.Add("267200725", "location-and-object");
            fileidToCategory.Add("268015829", "location-and-object");
            fileidToCategory.Add("28666901", "location-and-object");
            fileidToCategory.Add("39619172", "location-and-object");
            fileidToCategory.Add("57008677", "location-and-object");
            fileidToCategory.Add("76200101", "location-and-object");
            fileidToCategory.Add("77659573", "location-and-object");
            fileidToCategory.Add("81344020", "location-and-object");
            fileidToCategory.Add("87370069", "location-and-object");
            fileidToCategory.Add("10860933", "地标名(大地图)");
            fileidToCategory.Add("129979412", "任务目标(在HUD右边)");
            fileidToCategory.Add("108566804", "已完成的地标说明");
            fileidToCategory.Add("96678629", "决斗场地图代码");
            fileidToCategory.Add("8290981", "merchant-talk");
            fileidToCategory.Add("165399380", "merchant-talk");
            fileidToCategory.Add("8379076", "more-desc");
            fileidToCategory.Add("50040644", "more-desc");
            fileidToCategory.Add("52183620", "more-desc");
            fileidToCategory.Add("127454222", "more-desc");
            fileidToCategory.Add("151931684", "more-desc");
            fileidToCategory.Add("164317956", "more-desc");
            fileidToCategory.Add("171157587", "more-desc");
            fileidToCategory.Add("191189508", "more-desc");
            fileidToCategory.Add("206046340", "more-desc");
            fileidToCategory.Add("224875171", "more-desc");
            fileidToCategory.Add("5759525", "more-ui");
            fileidToCategory.Add("9019316", "more-ui");
            fileidToCategory.Add("9424005", "more-ui");
            fileidToCategory.Add("17915077", "more-ui");
            fileidToCategory.Add("26811173", "more-ui");
            fileidToCategory.Add("30721042", "more-ui");
            fileidToCategory.Add("32217908", "more-ui");
            fileidToCategory.Add("34157141", "more-ui");
            fileidToCategory.Add("37408565", "more-ui");
            fileidToCategory.Add("40741187", "more-ui");
            fileidToCategory.Add("42041397", "more-ui");
            fileidToCategory.Add("44699029", "more-ui");
            fileidToCategory.Add("45378037", "more-ui");
            fileidToCategory.Add("51109077", "more-ui");
            fileidToCategory.Add("57010981", "more-ui");
            fileidToCategory.Add("57026306", "more-ui");
            fileidToCategory.Add("65447205", "more-ui");
            fileidToCategory.Add("68561141", "more-ui");
            fileidToCategory.Add("71626837", "more-ui");
            fileidToCategory.Add("71931413", "more-ui");
            fileidToCategory.Add("79246725", "more-ui");
            fileidToCategory.Add("96962005", "more-ui");
            fileidToCategory.Add("99527054", "more-ui");
            fileidToCategory.Add("101034709", "more-ui");
            fileidToCategory.Add("106474997", "more-ui");
            fileidToCategory.Add("108643301", "more-ui");
            fileidToCategory.Add("111863941", "more-ui");
            fileidToCategory.Add("112701171", "more-ui");
            fileidToCategory.Add("112758405", "more-ui");
            fileidToCategory.Add("115337253", "more-ui");
            fileidToCategory.Add("115696037", "more-ui");
            fileidToCategory.Add("124318053", "more-ui");
            fileidToCategory.Add("125518133", "more-ui");
            fileidToCategory.Add("131421317", "more-ui");
            fileidToCategory.Add("143563989", "more-ui");
            fileidToCategory.Add("143811061", "more-ui");
            fileidToCategory.Add("148355781", "more-ui");
            fileidToCategory.Add("151600453", "more-ui");
            fileidToCategory.Add("156152165", "more-ui");
            fileidToCategory.Add("158979221", "more-ui");
            fileidToCategory.Add("162144901", "more-ui");
            fileidToCategory.Add("173340693", "more-ui");
            fileidToCategory.Add("180809749", "more-ui");
            fileidToCategory.Add("188513717", "more-ui");
            fileidToCategory.Add("191379205", "more-ui");
            fileidToCategory.Add("196014052", "more-ui");
            fileidToCategory.Add("200521140", "more-ui");
            fileidToCategory.Add("200697509", "more-ui");
            fileidToCategory.Add("203274254", "more-ui");
            fileidToCategory.Add("204530069", "more-ui");
            fileidToCategory.Add("207758933", "more-ui");
            fileidToCategory.Add("210591177", "more-ui");
            fileidToCategory.Add("216055893", "more-ui");
            fileidToCategory.Add("216271813", "more-ui");
            fileidToCategory.Add("217086453", "more-ui");
            fileidToCategory.Add("219429541", "more-ui");
            fileidToCategory.Add("219582791", "more-ui");
            fileidToCategory.Add("224768149", "more-ui");
            fileidToCategory.Add("224972965", "more-ui");
            fileidToCategory.Add("232566869", "more-ui");
            fileidToCategory.Add("236931909", "more-ui");
            fileidToCategory.Add("241484741", "more-ui");
            fileidToCategory.Add("242643895", "more-ui");
            fileidToCategory.Add("245765621", "more-ui");
            fileidToCategory.Add("251183959", "more-ui");
            fileidToCategory.Add("257983733", "more-ui");
            fileidToCategory.Add("259128606", "more-ui");
            fileidToCategory.Add("18173141", "收藏品名");
            fileidToCategory.Add("211640654", "收藏品描述");
            fileidToCategory.Add("33425332", "npc-name");
            fileidToCategory.Add("51188660", "npc-name");
            fileidToCategory.Add("96069573", "npc-name");
            fileidToCategory.Add("191999749", "npc-name");
            fileidToCategory.Add("207398837", "npc-name");
            fileidToCategory.Add("116521668", "quest-end");
            fileidToCategory.Add("168415844", "quest-end");
            fileidToCategory.Add("7949764", "任务目标");
            fileidToCategory.Add("234743124", "未知(任务相关?)");
            fileidToCategory.Add("144228340", "走私任务?(不确定)");
            fileidToCategory.Add("3952276", "任务-交谈(长)");
            fileidToCategory.Add("55049764", "任务-交谈");
            fileidToCategory.Add("200879108", "任务-交谈(长)2");
            fileidToCategory.Add("103224356", "任务-交谈(长)3");
            fileidToCategory.Add("115740052", "任务-NPC对白");
            fileidToCategory.Add("187173764", "任务-NPC对白2");
            fileidToCategory.Add("66737390", "任务-与NPC交谈");
            fileidToCategory.Add("121487972", "任务-与NPC交谈2");
            fileidToCategory.Add("204987124", "任务-与NPC交谈的选择");
            fileidToCategory.Add("228103012", "任务-与NPC交谈的选择2");
            fileidToCategory.Add("232026500", "接受任务选项2");
            fileidToCategory.Add("249936564", "接受任务选项3");
            fileidToCategory.Add("256430276", "任务目标2");
            fileidToCategory.Add("66848564", "任务NPC打招呼");
            fileidToCategory.Add("20958740", "接受任务选项");
            fileidToCategory.Add("205344756", "任务目标描述");
            fileidToCategory.Add("267697733", "任务物品名");
            fileidToCategory.Add("139139780", "任务物品描述");
            fileidToCategory.Add("38727365", "套装名");
            fileidToCategory.Add("198758357", "技能名");
            fileidToCategory.Add("132143172", "技能描述");
            fileidToCategory.Add("116704773", "阵营名");
            fileidToCategory.Add("235463860", "阵营描述");
            fileidToCategory.Add("4922190", "tip");
            fileidToCategory.Add("13753646", "tip");
            fileidToCategory.Add("18104308", "tip");
            fileidToCategory.Add("24991438", "tip");
            fileidToCategory.Add("26044436", "tip");
            fileidToCategory.Add("35111812", "tip");
            fileidToCategory.Add("37288388", "tip");
            fileidToCategory.Add("39248996", "tip");
            fileidToCategory.Add("41714900", "tip");
            fileidToCategory.Add("43934149", "tip");
            fileidToCategory.Add("46427668", "tip");
            fileidToCategory.Add("49496084", "tip");
            fileidToCategory.Add("50143374", "tip");
            fileidToCategory.Add("56558612", "tip");
            fileidToCategory.Add("57952500", "tip");
            fileidToCategory.Add("58548677", "tip");
            fileidToCategory.Add("60008005", "tip");
            fileidToCategory.Add("60139732", "tip");
            fileidToCategory.Add("62156964", "tip");
            fileidToCategory.Add("63937076", "tip");
            fileidToCategory.Add("74148292", "tip");
            fileidToCategory.Add("81761156", "tip");
            fileidToCategory.Add("84281828", "tip");
            fileidToCategory.Add("86601028", "tip");
            fileidToCategory.Add("86917166", "tip");
            fileidToCategory.Add("91126884", "tip");
            fileidToCategory.Add("101286772", "tip");
            fileidToCategory.Add("102062948", "tip");
            fileidToCategory.Add("104708420", "tip");
            fileidToCategory.Add("106360516", "tip");
            fileidToCategory.Add("115318052", "tip");
            fileidToCategory.Add("115391780", "tip");
            fileidToCategory.Add("117539474", "tip");
            fileidToCategory.Add("121548292", "tip");
            fileidToCategory.Add("123229230", "tip");
            fileidToCategory.Add("129382708", "tip");
            fileidToCategory.Add("130851621", "tip");
            fileidToCategory.Add("132595845", "tip");
            fileidToCategory.Add("135729940", "tip");
            fileidToCategory.Add("139528164", "tip");
            fileidToCategory.Add("139757006", "tip");
            fileidToCategory.Add("141135108", "tip");
            fileidToCategory.Add("142011652", "tip");
            fileidToCategory.Add("144446238", "tip");
            fileidToCategory.Add("145410824", "tip");
            fileidToCategory.Add("145684164", "tip");
            fileidToCategory.Add("148453652", "tip");
            fileidToCategory.Add("153349653", "tip");
            fileidToCategory.Add("154659316", "tip");
            fileidToCategory.Add("155022052", "tip");
            fileidToCategory.Add("156570558", "tip");
            fileidToCategory.Add("156664686", "tip");
            fileidToCategory.Add("160227428", "tip");
            fileidToCategory.Add("164328533", "tip");
            fileidToCategory.Add("164387044", "tip");
            fileidToCategory.Add("168351172", "tip");
            fileidToCategory.Add("168675493", "tip");
            fileidToCategory.Add("168857941", "tip");
            fileidToCategory.Add("172689156", "tip");
            fileidToCategory.Add("185724645", "tip");
            fileidToCategory.Add("191744852", "tip");
            fileidToCategory.Add("193511764", "tip");
            fileidToCategory.Add("193678788", "tip");
            fileidToCategory.Add("199723588", "tip");
            fileidToCategory.Add("202153303", "tip");
            fileidToCategory.Add("212113054", "tip");
            fileidToCategory.Add("217056980", "tip");
            fileidToCategory.Add("220262196", "tip");
            fileidToCategory.Add("221172404", "tip");
            fileidToCategory.Add("226966585", "tip");
            fileidToCategory.Add("230486948", "tip");
            fileidToCategory.Add("235850260", "tip");
            fileidToCategory.Add("237304340", "tip");
            fileidToCategory.Add("243094948", "tip");
            fileidToCategory.Add("246790420", "tip");
            fileidToCategory.Add("249633428", "tip");
            fileidToCategory.Add("251542164", "tip");
            fileidToCategory.Add("252100948", "tip");
            fileidToCategory.Add("253017305", "tip");
            fileidToCategory.Add("254784612", "tip");
            fileidToCategory.Add("256705124", "tip");
            fileidToCategory.Add("259956452", "tip");
            fileidToCategory.Add("264079508", "tip");
            fileidToCategory.Add("264355726", "tip");
            fileidToCategory.Add("266730334", "tip");
            fileidToCategory.Add("22296053", "title");
            fileidToCategory.Add("60155541", "title");
            fileidToCategory.Add("63563637", "title");
            fileidToCategory.Add("87522148", "title");
            fileidToCategory.Add("143348165", "title");
            fileidToCategory.Add("186232436", "title");
            fileidToCategory.Add("215700677", "title");
            fileidToCategory.Add("221887989", "title");
            fileidToCategory.Add("14464837", "陷阱");
            fileidToCategory.Add("59991493", "放置的家具互动");
            fileidToCategory.Add("39160885", "藏宝图名");
        }



    }

}
