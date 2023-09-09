using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Plane
    {
        private string model_plane;
        private string company;
        private int year_of_issue;
        private string type_plane;

        public Plane()
        {
            model_plane= string.Empty;
            company= string.Empty;  
            year_of_issue= 0;
            type_plane= string.Empty;

        }

        public Plane(string model_plane, string company, int year_of_issue, string type_plane)
        {
            this.model_plane = model_plane;
            this.company = company;
            this.year_of_issue = year_of_issue;
            this.type_plane = type_plane;
        }

        public void Input()
        {
            Console.WriteLine("Enter model plane");
            model_plane = Console.ReadLine();
            Console.WriteLine("Enter company");
            company = Console.ReadLine();
            Console.WriteLine("Enter year of issue");
            year_of_issue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type plane");
            type_plane = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Model plane -> {model_plane}\nCompany -> {company}\nYear of issue -> {year_of_issue}\nType plane -> {type_plane}";
        }

        public string ModelPlane
        {
            get 
            { 
                return model_plane;
            }
            set 
            { 
                model_plane = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set 
            { 
                company = value; 
            }
        }

        public int YearOfIssue
        {
            get
            {
                return year_of_issue;
            }
            set
            {
                year_of_issue = value;
            }

        }

        public string TypePlane
        {
            get
            {
                return type_plane;
            }
            set
            {
                type_plane = value;
            }
        }
    }
}
