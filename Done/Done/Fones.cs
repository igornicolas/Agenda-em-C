using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Done
{
    public class Fones
    {
        private string _telefone;
        private string _tipo;

        public string telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }

        public string tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public Fones(string num, string _tipo)
        {
            telefone = num;
            tipo = _tipo;
        }

        public override string ToString()
        {
            return string.Format("telefone: {0}\ntipo: {1}",
                this.telefone, this.tipo);
        }
    }
}

