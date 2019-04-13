﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillAway
{
    public static class drills
    {
        public static int[] MoveZeroes(int[] arr)
        {
            //if arr[i] != 0 add to new array.  if == 0 count up.  and count(s) 0s to array and return
            List<int> newlist = new List<int>();
            int count = 0;
            foreach (int i in arr)
            {
                if (i != 0) { newlist.Add(i); }
                else { count++; }
            }
            while (count > 0) { newlist.Add(0); count--; }
            return newlist.ToArray();
        }

        public static int MaxSequence(int[] arr)
        {
            int max = 0;
            //set max to arr[0], if arr[0] + arr[
            int subsetCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum += arr[j];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[k] == sum)
                        {
                            subsetCount++;
                           
                        }
                        if (sum > max) { max = sum; }
                    }
                    
                }
                
            }
            return max;
        }

        public static string Rot13(string message)
        {
            string mes13 = "";
            
          foreach (char c in message)
            {
                int d =  Convert.ToInt16(c);
                if (d > 64 && d < 77 || d >= 97 && d < 110)
                { d = d + 13; }
                else if (d >= 77 && d <= 90 || d >= 110 && d < 123)
                { d = d - 13; }
                else { d = d; }
                char e = Convert.ToChar(d);
                mes13 = mes13 + e;
               
            }
            return mes13;
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            string phonenumber = "";
            foreach (int i in numbers)
            {
                phonenumber = phonenumber + i.ToString();
            }
            phonenumber = phonenumber.Insert(0, "(");
            phonenumber = phonenumber.Insert(4, ")");
            phonenumber = phonenumber.Insert(5, " ");
            phonenumber = phonenumber.Insert(9, "-");
            return phonenumber;
        }

        public static string Likes(string[] name)
        {
            int x = name.Count();
            int rest = x - 2;
            if (x == 0)
            { return "no one likes this"; }
            else if (x == 1)
            { return name[0] + " likes this"; }
            else if (x == 2)
            { return name[0] + " and " + name[1] + " like this"; }
            else if (x == 3)
            { return name[0] + ", " + name[1] + " and " + name[2] + " like this"; }
            else if (x > 3)
            { return name[0] + ", " + name[1] + " and " + rest + " others like this"; }
            else return "oops";
        }
    }
}

