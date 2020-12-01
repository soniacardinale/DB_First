using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDB1
{
    public partial class Prenotazioni
    {
        public int Id { get; set; }
        public int? NumeroPosti { get; set; }
        public string Mail { get; set; }
        public int ProgrammazioneId { get; set; }

        public virtual Programmazione Programmazione { get; set; }
    }
}
