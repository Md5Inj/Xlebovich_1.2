using System;

namespace lab1._2 {
    class Teacher {
        public string Surname { get; set; }
        public string Com { get; set; }
        public double Experience { get; set; }

        public Teacher(string Surname, string Com, double Experience)
        {
            this.Surname = Surname;
            this.Com = Com;
            this.Experience = Experience;
        }
    }
}