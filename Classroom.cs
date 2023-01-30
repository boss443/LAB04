using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LAB4Encapsulation
{
    public class Classroom
    {
        private string name;

        private List<Person> persons = new List<Person>();
        double maxGPA = 0, minGPA = int.MaxValue;
        double iGPA = 0;
        string nameMax = "", nameMin = "";

        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPerson2Classs(Person p)
        {
            this.persons.Add(p);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public int showSumAgeinClass()
        {
            int sumAge = 0;
            foreach (Person p in this.persons)
            {
                sumAge += p.getAge();
            }
            return sumAge;
        }
        public double showMaxGPAinClass()
        {
            foreach (Person p in this.persons)
            {
                iGPA = p.getGPA();
            }
            if (iGPA > maxGPA)
            {
                maxGPA = iGPA;
            }
            if (iGPA < minGPA)
            {
                minGPA = iGPA;
            }
            return maxGPA;
        }
        public double showMinGPAinClass()
        {
            foreach (Person p in this.persons)
            {
                iGPA = p.getGPA();
            }
            if (iGPA > maxGPA)
            {
                maxGPA = iGPA;
            }
            if (iGPA < minGPA)
            {
                minGPA = iGPA;
            }
            return minGPA;
        }
        public double showAvgGPAinClass()
        {
            double iGPA = 0;
            int n = 0;
            foreach (Person p in this.persons)
            {
                iGPA += p.getGPA();
                n++;
            }
            return iGPA / n;
        }
        public string showNameMaxGPAinClass()
        {
            foreach (Person p in this.persons)
            {
                iGPA = p.getGPA();
                name = p.getName();
            }
            if (iGPA > maxGPA)
            {
                maxGPA = iGPA;
            }
            if (iGPA < minGPA)
            {
                minGPA = iGPA;
            }
            if (iGPA == maxGPA)
            {
                this.nameMax = name;
            }
            return nameMax;
        }
        public string showNameMinGPAinClass()
        {
            foreach (Person p in this.persons)
            {
                iGPA = p.getGPA();
                name = p.getName();
            }
            if (iGPA > maxGPA)
            {
                maxGPA = iGPA;
            }
            if (iGPA < minGPA)
            {
                minGPA = iGPA;
            }
            if (iGPA == minGPA)
            {
                this.nameMin = name;
            }
            return nameMin;
        }
    }
}
