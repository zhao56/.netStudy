﻿using System;
using System.Collections.Generic;
using System.Text;

namespace zhao56.study.basic.Generic
{

    public interface ISports
    {
        void Pingpang();
    }

    public interface IWork
    {
        void Work();
    }


    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Hi()
        { }

    }

    public class Chinese : People, ISports, IWork
    {
        public void Tradition()
        {
            Console.WriteLine("仁义礼智信，温良恭俭让");
        }
        public void SayHi()
        {
            Console.WriteLine("吃了么？");
        }

        public void Pingpang()
        {
            Console.WriteLine("打乒乓球...");
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    public class Hubei : Chinese
    {
        //public Hubei(int i)
        //{ }

        public string Changjiang { get; set; }
        public void Majiang()
        {
            Console.WriteLine("打麻将啦。。");
        }
    }


    public class Japanese : ISports
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void Pingpang()
        {
            Console.WriteLine("打乒乓球...");
        }
    }
}
