﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelBL.Model
{
    public class TypeGlossary // 3 kol vast, rij variable
    {
        public string Naam { get; set; }
        public string DataType { get; set; }
        public int AantalKolommen { get; set; }
        public int AantalRijen { get; set; }



        /// <summary>
        /// ///
        /// </summary>

        /*public ObservableCollection<string> Rijen { get; } = new ObservableCollection<string>();

        public void VoegRijToe()
        {
            Rijen.Add("Nieuwe rij");
        }*/
    }
}
