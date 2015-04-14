namespace _01_03.Student
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    #region enumerations
    public enum EnumUniversity
    {
        SofiaUniversity,
        BurgasFreeUniversity,
        UNWE
    }

    public enum EnumFaculty
    {
        Mathematics,
        Economy,
        IT
    }

    public enum EnumSpeciality
    {
        SoftwareEngineer,
        Mathematician,
        Economist
    }
    #endregion

    public class Student : ICloneable, IComparable
    {
        public Student(
            string firstName, 
            string middleName,
            string lastName, 
            ulong ssn, 
            string address, 
            string phone, 
            string email,
            EnumUniversity university, 
            int course, 
            EnumFaculty faculty, 
            EnumSpeciality speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.University = university;
            this.Course = course;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public ulong SSN { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int Course { get; set; }

        public EnumUniversity University { get; set; }

        public EnumFaculty Faculty { get; set; }

        public EnumSpeciality Speciality { get; set; }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }

        public object Clone()
        {
            Student clonedStudent = new Student(
                this.FirstName, 
                this.MiddleName, 
                this.LastName, 
                this.SSN, 
                this.Address, 
                this.Phone, 
                this.Email,
                this.University, 
                this.Course, 
                this.Faculty, 
                this.Speciality);

            return clonedStudent;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }
            else if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            else if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }
            else if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }
            else
            {
                return 0;
            } 
        }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName) ||
                !this.MiddleName.Equals((obj as Student).MiddleName) ||
                !this.LastName.Equals((obj as Student).LastName) ||
                !this.SSN.Equals((obj as Student).SSN) ||
                !this.Phone.Equals((obj as Student).Phone) ||
                !this.Address.Equals((obj as Student).Address) ||
                !this.Email.Equals((obj as Student).Email) ||
                !this.Faculty.Equals((obj as Student).Faculty) ||
                !this.Course.Equals((obj as Student).Course) ||
                !this.University.Equals((obj as Student).University) ||
                !this.Speciality.Equals((obj as Student).Speciality))
            {
                return false;
            }
            else 
            { 
                return true; 
            }
        }

        public override int GetHashCode()
        {
            string studentInfoString = this.FirstName + this.MiddleName + this.LastName + this.SSN;
            int hashCode = studentInfoString.GetHashCode();

            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(string.Format("SSN: {0}", this.SSN));

            return result.ToString();
        }
    }
}