using System;
using System.Collections.Generic;
using FreeSql.DataAnnotations;

namespace FreeSqlConsole
{
    class Program
    {

        const string connectionString = "Data Source=39.100.97.234;Port=3306;User ID=root;Password=123456;Initial Catalog=my-test;Charset=utf8;SslMode=none;Max pool size=10";

        static IFreeSql fsql = new FreeSql.FreeSqlBuilder()
            .UseConnectionString(FreeSql.DataType.MySql, connectionString)
            .UseAutoSyncStructure(true) //自动同步实体结构到数据库
            .Build(); //请务必定义成 Singleton 单例模式

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
           
            //for (var a = 0; a < 100; a++) items.Add(new Topic { Id = a + 1, Title = $"newtitle{a}", Clicks = a * 100, Guid = Guid.NewGuid().ToString() });
            for (var a = 0; a < 100000; a++)
            {
                var items = new List<Topic>();
                string newGuid = Guid.NewGuid().ToString();

                items.Add(new Topic
                {
                    Id = a + 1,
                    Title = $"newtitle{a}",
                    Clicks = a * 100,
                    Guid = newGuid
                });

                var itemsV = new List<TopicValue>();
                for (int b = 0; b < 10; b++)
                {
                    itemsV.Add(new TopicValue
                    {
                        Id = a * 10 + b + 1,
                        Guid = newGuid
                    });
                }
                fsql.Insert(itemsV).ExecuteAffrows();

                fsql.Insert(items).ExecuteAffrows();
            }

            

        }

    }

    public class Topic
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }
        public int Clicks { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;

        public string Guid { get; set; }

        public string Vaue01 { get; set; }
        public string Vaue02 { get; set; }
        public string Vaue03 { get; set; }
        public string Vaue04 { get; set; }
        public string Vaue05 { get; set; }
        public string Vaue06 { get; set; }
        public string Vaue07 { get; set; }
        public string Vaue08 { get; set; }
        public string Vaue09 { get; set; }
        public string Vaue10 { get; set; }
        public string Vaue11 { get; set; }
        public string Vaue12 { get; set; }
        public string Vaue13 { get; set; }
        public string Vaue14 { get; set; }
        public string Vaue15 { get; set; }
        public string Vaue16 { get; set; }
        public string Vaue17 { get; set; }
        public string Vaue18 { get; set; }
        public string Vaue19 { get; set; }
        public string Vaue20 { get; set; }

    }

    public class TopicValue
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }

        public string Guid { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public string Vaue01 { get; set; }
        public string Vaue02 { get; set; }
        public string Vaue03 { get; set; }
        public string Vaue04 { get; set; }
        public string Vaue05 { get; set; }
        public string Vaue06 { get; set; }
        public string Vaue07 { get; set; }
        public string Vaue08 { get; set; }
        public string Vaue09 { get; set; }
        public string Vaue10 { get; set; }
        public string Vaue11 { get; set; }
        public string Vaue12 { get; set; }
        public string Vaue13 { get; set; }
        public string Vaue14 { get; set; }
        public string Vaue15 { get; set; }
        public string Vaue16 { get; set; }
        public string Vaue17 { get; set; }
        public string Vaue18 { get; set; }
        public string Vaue19 { get; set; }
        public string Vaue20 { get; set; }

    }

}
