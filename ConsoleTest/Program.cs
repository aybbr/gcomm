using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
       
        static void Main(string[] args)
        {


           // ISimpleMemberService test = new SimpleMemberService();
            //    test.Add(new simplemember {DTYPE="ActiveMember",email="mokhtar.benhmida@esprit.tn",name="momo",
           //    password="vvvv",server="euw",summonerName="sdf",surname="fd",username="jjh",xp=60,approved=true,phone=4654,role="kljlkj"});

            IPacksService test = new PacksService();
            test.Add(new pack { category = "az",datemiseenligne= new DateTime(),name="jlkj",price=50,quantity=65 });


            Console.WriteLine("aaaaaaaaaaaa");
            Console.ReadKey();
        }
    }
}
