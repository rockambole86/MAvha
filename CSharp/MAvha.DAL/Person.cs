using System;

namespace MAvha.DAL
{
    public enum Gender
    {
        Masculino,
        Femenino
    }

    public class Person
    {
        public int      Id       { get; set; } = 0;
        public string   Fullname { get; set; }
        public DateTime DOB      { get; set; }
        public int      Age      { get; set; }
        public Gender   Gender   { get; set; } = Gender.Masculino;
        public bool     IsActive { get; set; } = true;
    }
}