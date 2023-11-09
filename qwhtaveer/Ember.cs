using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwhtaveer
{
	class Ember
	{
		private string nev;
		private int eletkor;

		public Ember(string nev, int eletkor)
		{
			this.nev = nev;
			this.eletkor = eletkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
	}
}
