using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles
{
    class WeakEntry
    {
        public WeakEntry(Type type1, Type type2, List<Type> immune)
        {
            List<Type> temp1 = new List<Type>();
            List<Type> temp2 = new List<Type>();
            List<Type> temp3 = new List<Type>();
            List<Type> temp4 = new List<Type>();

            if (type2 == null)
            {
                foreach (Type a in type1.getWeaknesses())
                {
                    singleweak.Add(a);
                }
                foreach (Type a in type1.getResistances())
                {
                    singleresist.Add(a);
                }
            }
            else
            {
                foreach (Type a in type1.getWeaknesses())
                {
                    singleweak.Add(a);
                }
                foreach (Type a in type1.getResistances())
                {
                    singleresist.Add(a);
                }

                foreach (Type a in type2.getWeaknesses())
                {
                    bool repeat = false;
                    Type temp = new Type();
                    foreach (Type b in singleweak)
                    {
                        if (a.GetType() == b.GetType())
                        {
                            repeat = true;
                            temp = b;
                        }
                    }
                    if (repeat)
                    {
                        singleweak.Remove(temp);
                        doubleweak.Add(temp);
                    }
                    else
                    {
                        singleweak.Add(a);
                    }
                }
                foreach (Type a in type2.getResistances())
                {
                    bool repeat = false;
                    foreach (Type b in singleresist)
                    {
                        if (a.GetType() == b.GetType())
                        {
                            repeat = true;
                        }
                    }
                    if (repeat)
                    {
                        singleresist.Remove(a);
                        doubleresist.Add(a);
                    }
                    else
                    {
                        singleresist.Add(a);
                    }
                }

                foreach (Type a in singleweak)
                {
                    temp1.Add(a);
                }
                foreach (Type a in doubleweak)
                {
                    temp2.Add(a);
                }
                foreach (Type a in singleresist)
                {
                    temp3.Add(a);
                }
                foreach (Type a in doubleresist)
                {
                    temp4.Add(a);
                }

                foreach (Type a in temp1)
                {
                    foreach (Type b in temp3)
                    {
                        if (b.ToString() == a.ToString())
                        {
                            singleweak.Remove(a);
                            singleresist.Remove(b);
                        }
                    }
                }

                foreach (Type a in immune)
                {
                    foreach (Type b in temp1)
                    {
                        if (b.ToString() == a.ToString())
                        {
                            singleweak.Remove(b);
                        }
                    }
                    foreach (Type b in temp2)
                    {
                        if (b.ToString() == a.ToString())
                        {
                            doubleweak.Remove(b);
                        }
                    }
                    foreach (Type b in temp3)
                    {
                        if (b.ToString() == a.ToString())
                        {
                            singleresist.Remove(b);
                        }
                    }
                    foreach (Type b in temp4)
                    {
                        if (b.ToString() == a.ToString())
                        {
                            doubleresist.Remove(b);
                        }
                    }
                }
            }

            this.immune = immune;
        }

        private List<Type> immune = new List<Type>();
        private List<Type> singleweak = new List<Type>();
        private List<Type> doubleweak = new List<Type>();
        private List<Type> singleresist = new List<Type>();
        private List<Type> doubleresist = new List<Type>();
        
        private List<Type> Immune { get { return immune; } }
        private List<Type> SingleWeak { get { return singleweak; } }
        private List<Type> DoubleWeak { get { return doubleweak; } }
        private List<Type> SingleResist { get { return singleresist; } }
        private List<Type> DoubleResist { get { return doubleresist; } }

        public override string ToString()
        {
            string stringer = "";
            stringer += "2x Weak: ";
            foreach (Type a in singleweak)
            {
                stringer += a.ToString() + ", ";
            }
            stringer += "\n";
            stringer += "4x Weak: ";
            foreach (Type a in doubleweak)
            {
                stringer += a.ToString() + ", ";
            }
            stringer += "\n";
            stringer += "2x Resist: ";
            foreach (Type a in singleresist)
            {
                stringer += a.ToString() + ", ";
            }
            stringer += "\n";
            stringer += "4x Resist: ";
            foreach (Type a in doubleresist)
            {
                stringer += a.ToString() + ", ";
            }
            stringer += "\n";
            stringer += "Immune: ";
            foreach (Type a in immune)
            {
                stringer += a.ToString() + ", ";
            }
            stringer += "\n";
            return stringer;
        }
    }
}
