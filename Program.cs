using System;

namespace Finder_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            开篇();
        }
        static void 开篇()
        {
            Console.WriteLine("在宇宙飞船外，是诱人的紫色与神奇的白点");
            ConsoleKeyInfo key1 = Console.ReadKey();
            Console.WriteLine("飞船像一位追求者般在宇宙的星光大道中前行");
            ConsoleKeyInfo key2 = Console.ReadKey();
            Console.WriteLine("洁白优雅的新郎，以光速的脚步，奔向光年之外的新娘");
            ConsoleKeyInfo key3 = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("不过，飞船里的那位兽，并不如此浪漫。");
            Console.WriteLine("“真不该干这份破工作的，都没人来陪我了。”");
            Console.WriteLine("突然，一阵铃声响起......");
            bool 下一步 = true;
            int 感情 = 10;
            for (; 下一步;)
            {
                Console.WriteLine("请输入接下来的行动（输入“查看”以获得可执行步骤）");
                string 行动1 = Console.ReadLine();
                if (行动1 == "查看")
                {
                    Console.WriteLine("1.接电话");
                    Console.WriteLine("2.走向窗户");
                }
                else if (行动1 == "接电话")
                {
                    Console.WriteLine("飞船内突然出现了一位极为美丽的人类少女。");
                    Console.WriteLine("她看到这只兽显得十分高兴，双方都飞奔扑向对方。");
                    Console.ReadKey();
                    Console.WriteLine("“你不是说好了不去干这么危险的事吗，你这只臭猫”婕妤十分激动的说道");
                    Console.WriteLine("“不是的啦，这宇宙实在太...”");
                    Console.WriteLine("此时这位少女脸蛋通红说：“胡说，你在地球和我谈恋爱的时候怎么给我说的，你当时时说你实在太美丽了，即使星辰也要在我黯淡几分。但现在呢，你（脏话）偷偷跑到黑到点嘞外太空耍，你个臭猫，看我今天不给你耳朵扯下来！！！”");
                    Console.WriteLine("此时少女向你跑了过来");
                    Console.WriteLine("少女用纤细洁白的手捏住了你小小的猫耳，你疼得喵喵叫");
                    int 挣脱值 = 0;
                    for (; 挣脱值 <= 30;) 
                    {
                        挣脱值 = 挣脱(挣脱值); 
                    }
                    Console.WriteLine("“哼，要不是看你一个在外太空孤独，不然我就把你尾巴也一起拔下来，懂了吗小猫，吴炜！”");
                    Console.WriteLine("吴炜满是惊恐的答道：“是的，亲爱的老婆大人，婕妤。”");
                    Console.WriteLine("“早点飞到S4714后回来看我，我才买的别墅很空呢！”说罢，量子实体化电话关掉了。");
                    感情 = 感情 + 1;
                    下一步 = false;
                }
                else if (行动1 == "走向窗户")
                {
                    Console.WriteLine("你若无其事的走向了窗户");
                    Console.WriteLine();
                    Console.WriteLine("但");
                    Console.ReadKey();
                    Console.WriteLine("你的身后变的冷飕飕的。");
                    Console.ReadKey();
                    Console.WriteLine("突然一阵刺骨的寒冷抓住了你的喉咙。");
                    Console.WriteLine("“大坏猫居然背着我跑了，还不接我电话，看我今天不狠狠收拾你。”");
                    Console.WriteLine("（刺骨的寒冷与令人清醒的痛苦提醒你做些什么）");
                    int 挣脱值 = 0;
                    for (; 挣脱值 <= 30;)
                    {
                        挣脱值 = 挣脱(挣脱值);
                    }
                    Console.WriteLine("“疼疼疼！，老婆大人”");
                    Console.WriteLine("“你还知道疼啊，一天天的，吴炜啊,居然敢背着我跑那么远的地方，还不给我说一声！”");
                    Console.WriteLine("“好的好的，老婆大人，婕妤，我知道错了”吴炜着急忙慌地说");
                    Console.WriteLine("说罢，婕妤松开了手，吴炜也落地。");
                    Console.WriteLine("“早点回来啊，我们还要搬家呢”婕妤挂断了电话，吴炜叹叹气，继续行驶起飞船......");
                    感情 = 感情 - 1;
                    下一步 = false;
                }
                else
                {
                    Console.WriteLine("（叮叮当当的电话使你无法将注意力放在其他事上）");
                }
                Console.WriteLine("next time...");
                Console.ReadKey();
            }
        }
        private static int 挣脱(int 挣脱值)
        {
            
                Console.WriteLine("（按下“E”键以挣脱）");
                ConsoleKeyInfo key4 = Console.ReadKey();
                if (key4.Key == ConsoleKey.E)
                {
                    挣脱值 = 挣脱值 + 1;
                    Console.WriteLine("你尝试挣扎了一下，但痛觉仍在你的耳朵上");
                }
                else
                {
                    Console.WriteLine("你并未反抗，但清晰的痛觉催促你做些什么。");
                }
                return 挣脱值;

            
        }
    }
}
