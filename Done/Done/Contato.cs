using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Done
{
    class Contato
    {
        #region Atributos
        private string email;
        private string nome;
        private List<Fones> fone;
        #endregion

        #region Propriedades
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public List<Fones> Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        #endregion

        #region Construtores
        public Contato(string email, string nome)
        {
            this.email = email;
            this.nome = nome;
            fone = new List<Fones>();
            
        }

        public Contato(string email) : this(email, "")
        { }

        public Contato()
            : this("", "")
        { }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return string.Format("e-mail: {0}\nNome: {1}",
                this.email, this.nome);
        }

        public override bool Equals(object obj)
        {
            return (this.email == ((Contato)obj).email);
        }
        #endregion

        public void adicionarTel(Fones c)
        {
            this.Fone.Add(c);
        }
        public bool removerTel(Fones c)
        {
            bool podeRemover;
            podeRemover = (this.Fone.IndexOf(c) > -1);
            if (podeRemover)
                this.Fone.RemoveAt(this.Fone.IndexOf(c));
            return podeRemover;
        }
    }
}
