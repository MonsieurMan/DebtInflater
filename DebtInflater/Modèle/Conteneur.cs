﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtInflater.Modèle
{
    class Conteneur : ICollection<Personne>
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Personne item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Personne item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Personne[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Personne> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Personne item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
