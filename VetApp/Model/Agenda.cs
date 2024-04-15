using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Model
{
    public class Agenda
    {
        private DateOnly data;
        private string hora;
        private Vet vet;
        private Pet pet;

        public DateOnly Data { get => data; set => data = value; }
        public string Hora { get => hora; set => hora = value; }
        public Vet Vet { get => vet; set => vet = value; }
        public Pet Pet { get => pet; set => pet = value; }
    }
}
