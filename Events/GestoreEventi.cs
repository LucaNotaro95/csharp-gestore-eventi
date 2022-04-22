using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class GestoreEventi
    {

        public DateTime dataOra;
        private string nome;
        private int postitotali;
        private int postidaprenotare;
        public int postifiniti;
        public int check;
        
        

        public GestoreEventi(string nome1, DateTime date2, int postitotali1)
        {





           

                setNome(nome1);
                setDataOra(date2);
               









            getPostitot();
            getPostitot();
            this.postitotali = postitotali1;
            this.postifiniti = postifiniti;
            this.check = check;
            
            

          






        }

      

       

        public void Prenotaposti(int b)
        {



            this.postidaprenotare = b;
            this.postifiniti = postitotali - postidaprenotare;


           
            

            



        }

        public void setPostitott(int postitotali1)

        {

            if (postitotali1 < 0)
            {

                throw new ArgumentOutOfRangeException();

            }

            this.postitotali = postitotali1;


        }

       
        public void Disdici(int p)
        {
            check=postidaprenotare;
            int flag = 1;
            
            


                if (p <= postidaprenotare)
                {
                    this.postidaprenotare = postidaprenotare - p;
                    flag = 0;

                }

                else
                {


                    Console.WriteLine("posti non a sufficienza,riprovare");
                    Console.WriteLine("quanti posti vuoi disdire?");
                }


            
           










        }
        public int getPostidapren()
        {

            return postidaprenotare;
            

           

        }


        

        public int getPostitot()
        {

           
            return postitotali;



        }

        public void setNome (string nome1)
        {

            if (nome1 == "ciao")
            {

                throw new ArgumentNullException(nameof(nome1));
            }

            else
            {

                this.nome = nome1;

            }
            

            


            }

        public void setDataOra(DateTime date2)
        {


            this.dataOra = date2;

            if (date2<DateTime.Now)
            {
                throw new InvalidCastException();

            }

          

        }













        override
        public string ToString() => "nome " + nome + "   posti1 " + postitotali + "   posti2 " + postidaprenotare + " posti" + postifiniti;


    }





    }





    








         

