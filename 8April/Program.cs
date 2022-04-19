﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace Console_review
{
    class FridayQuestions
    {
        #region Soru1
        //1) 2010 ile 2022 arasında mesai saatleri içerisinde (09:00-18:00) 1000 adet RANDOM TARİH oluştur ve bir tarih listesine ata
        static List<DateTime> Soru1(int length = 1000)
        {
            List<DateTime> dateList = new List<DateTime>();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                int year = rnd.Next(2010, 2023);
                int month = rnd.Next(1, 13);
                int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                dateList.Add(new DateTime(year, month, day, rnd.Next(09, 18), rnd.Next(0, 60), 0));
            }
            return dateList;
        }
        #endregion
        #region Soru2
        //2) Bu listede cumartesi ve pazar olmasın!
        static List<DateTime> Soru2(List<DateTime> dateList)
        {
            dateList.RemoveAll(x => x.DayOfWeek != DayOfWeek.Sunday && x.DayOfWeek != DayOfWeek.Saturday);
            return dateList;
        }
        #endregion
        #region Soru3
        //3) Bu listenin içerisinde tarihlerin kaçı şubat ayı içerisindedir?
        static int Soru3(List<DateTime> dateList)
        {
            return dateList.FindAll(x => x.Month == 2).Count();
        }
        #endregion
        #region Soru4
        //        4) Bu listenin içerisindeki tarihlerin kaçı 12:00 (öğlen) den öncedir
        static int Soru4(List<DateTime> dateList)
        {
            return dateList.Where(x => x.Hour < 12).Count();
        }
        #endregion
        #region Soru5
        //5) Bu listede kaç tane pazartesi var?
        static int Soru5(List<DateTime> dateList)
        {
            int total = 0;
            for (int i = 0; i < dateList.Count(); i++)
            {
                if (dateList[i].DayOfWeek == DayOfWeek.Monday)
                {
                    total++;
                }
            }
            return total;
        }
        #endregion
        #region Soru6
        //6) Saat aralığı 17:00 - 18:00 arasında olan tüm tarihleri ekrana yaz
        static void Soru6(List<DateTime> dateList)
        {
            CultureInfo local = CultureInfo.CurrentCulture;
            foreach (DateTime date in dateList)
            {
                if (date.Hour == 17)
                {
                    Console.WriteLine(date.ToString(local));
                }
            }
        }
        #endregion
        #region Soru7
        //7) Kullanıcı ekrandan bir yıl girsin ve o yıla ait tüm tarihleri ekrana yaz
        static void Soru7(List<DateTime> dateList)
        {
            Console.WriteLine("bir yil giriniz: ");
            int year = Convert.ToInt32(Console.ReadLine());
            List<DateTime> listOnYear = dateList.Where(x => x.Year == year).ToList();
            foreach (DateTime date in dateList)
            {
                Console.WriteLine(date.ToString("dddd.dd.MMMM.HHHH:mm", CultureInfo.CurrentCulture));
            }
        }
        #endregion
        #region Soru8
        //8) Kullanıcı ekrandan önce yıl sonra ay girsin ve bu ay ve yıla ait tüm tarihler sıralansın.
        static void Soru8(List<DateTime> dateList)
        {
            Console.WriteLine("Yili giriniz: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ayi giriniz: ");
            int month = Convert.ToInt32(Console.ReadLine());
            List<DateTime> filteredList = dateList.Where(x => x.Year == year && x.Month == month).ToList();
            foreach (DateTime date in filteredList)
            {
                Console.WriteLine(date.ToString("dddd.dd.MMMM.HHHH:mm", CultureInfo.CurrentCulture));
            }
        }
        #endregion
        #region Soru9
        //9) 2010 SONRASI tarihleri ekrana yazdır.
        static void Soru9(List<DateTime> dateList)
        {
            List<DateTime> filteredList = dateList.Where(x => x.Year > 2010).ToList();
            foreach (DateTime date in filteredList)
            {
                Console.WriteLine(date.ToString("dddd.dd.MMMM.HHHH:mm", CultureInfo.CurrentCulture));
            }
        }
        #endregion
        #region Soru10
        //10) 2010-2015 arasında SADECE OCAK ayında geçen tarihleri ekrana yazdır.
        static void Soru10(List<DateTime> dateList)
        {
            List<DateTime> filteredList = dateList.FindAll(x => x.Year >= 2010 && x.Year <= 2015 && x.Month == 1);
            foreach (DateTime date in filteredList)
            {
                Console.WriteLine(date.ToString("dddd.dd.MMMM.HHHH:mm", CultureInfo.CurrentCulture));
            }
        }
        #endregion
        static void Main(string[] args)
        {
           

        }
    }
}
