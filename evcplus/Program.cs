using System;
namespace evcplus
{
    class Program
    {
        static void Main(string[] args)
        {
      



            MainMenu();

        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("EVC PLUS ");
            Console.WriteLine("");
            Console.WriteLine("1:Itus Hraaga");
            Console.WriteLine("2:Kaarka hadalka");
            Console.WriteLine("3:Bixi Biil");
            Console.WriteLine("4:U Wareeji EVCPLUS");
            Console.WriteLine("5:Warbixin Kooban");
            Console.WriteLine("6:Salaam Bank");
            Console.WriteLine("7:Maareyn");
            Console.WriteLine("8:Taaj");
            Console.WriteLine("9:Bill Payment");

            string MyOption;

            MyOption = Console.ReadLine();

            switch (MyOption)
            {

                case "1":
                    k();
                    break;
                case "2":
                    l();
                    break;
                case "3":
                    M();
                    break;
                case "4":
                    Uwareeji();
                    break;
                case "5":
                    WarbixinKooban();
                    break;
                case "6":
                    Salaam();
                    break;
                case "7":
                    Maareynta();
                    break;
                case "8":
                    TAAJ();
                    break;
                case "9":
                    Bill();
                    break;

            }

            MainMenu();
        }



        static void k()
        {
            Console.WriteLine("Haraagaagu Waa 190$");
            Console.ReadLine();
        }
        static void l()
        {
            Console.WriteLine("");
            Console.WriteLine("1:Ku Shubo Airtime ");
            Console.WriteLine("2:Ugu Shub Airtime");
            string myoption2;
            myoption2 = Console.ReadLine();

            switch (myoption2)
            {
                case "1":
                    KuShubo();
                    break;
                case "2":
                    UguShub();
                    break;
            }
            MainMenu();

        }


        static void KuShubo()
        {
            Console.WriteLine("");



            Console.WriteLine("Fadlan Gali Lacagta");
            string Lacag = Console.ReadLine();
            Console.WriteLine("MahaubTaa Inaad KuShubatid " + Lacag);
            Console.WriteLine("1:Haa");
            Console.WriteLine("2:Mya");


            Lacag = Console.ReadLine();

            switch (Lacag)
            {
                case "1":

                    Haa();

                    break;

                case "2":
                    maya();
                    break;




            }



        }

        static void Haa()
        {

            Console.WriteLine("Waad Ku Shubatay Waad Ku Mahadsantahay Isticmaalka Isticmaalka AdeeGa Mahadsanid ");

            Console.ReadLine();


        }


        static void maya()
        {
            Console.WriteLine("LaguMa Guulaysan Howshan MHDSNID");

            Console.ReadLine();






        }
        static void UguShub()
        {

            Console.WriteLine("Fadlan Geli Mobile-ka");
            string SoogashoNumberkaga = Console.ReadLine();
            Console.WriteLine("FadLan Soo Geli Lacagta");
            string SoogashoLacagta = Console.ReadLine();
            Console.WriteLine("Mahubtaa Inaad U Wareejisay " + SoogashoLacagta);

            Console.WriteLine("Numberka" + SoogashoNumberkaga);
            Console.WriteLine("");
            Console.WriteLine("1:Haa");
            Console.WriteLine("2:Maya");

            string Myoption3;

            Myoption3 = Console.ReadLine();
            switch (Myoption3)
            {
                case "1":
                    Haaa();
                    break;

                case "2":
                    Mayaa();
                    break;
            }
        }
        static void Haaa()
        {
            Console.WriteLine("");
            Console.WriteLine("Waad Ugu Shubtay Numberka WaadNa Ku Guulaysatay Adeegan Mahadsanid ");
            Console.ReadLine();




        }
        static void Mayaa()
        {
            Console.WriteLine("LagumaGuulaysan Howshan Mahadsanid");
            Console.ReadLine();
        }

        static void M()
        {

            Console.WriteLine("Laguma Guulaysan Howshan Mahadsanid");
            Console.ReadLine();



        }
        static void Uwareeji()
        {
            Console.WriteLine("FadLan Geli Mobile-Ka");
            string gashoNumberkaLooTuurayoLacagta = Console.ReadLine();
            Console.WriteLine("Fadlan Geli Lacagtaa");
            string gashoLacagta = Console.ReadLine();
            Console.WriteLine("Mahubtaa Inaad Uwareejisay " + gashoLacagta);
            Console.WriteLine("Lambarka " + gashoNumberkaLooTuurayoLacagta);
            Console.WriteLine("1:Haa");
            Console.WriteLine("2:Maya");
            string myoption5;
            myoption5 = Console.ReadLine();

            switch (myoption5)
            {
                case "1":
                    Haaaa();
                    break;
                case "2":
                    Mayaaa();
                    break;

            }
        }
        static void Haaaa()
        {
            Console.WriteLine("Waad ugu shubtay waadna KU guu Laysatay Howshan Mahadsanid");
            Console.ReadLine();
        }
        static void Mayaaa()
        {
            Console.WriteLine("Laguma Guulaysan Howshan Mahadsanid!");
            Console.ReadLine();
        }
        static void WarbixinKooban()
        {
            Console.WriteLine("Laguma Guulaysan Howshan Mahadsanid ");
            Console.ReadLine();
        }

        static void Salaam()
        {

            Console.WriteLine("Laguma Guulaysan Mahadsanid");
            Console.ReadLine();


        }
        static void Maareynta()
        {
            Console.WriteLine("Laguma Guulaysan Mahadsanid");
            Console.ReadLine();
        }
        static void TAAJ()
        {
            Console.WriteLine("Lagum Guulaysan Mahadsanid");
            Console.ReadLine();
        }

        static void Bill()
        {
            Console.WriteLine("Laguma Guulaysan Mahadsanid");
            Console.ReadLine();
        }

    }
}




   




    

    
     
   


    

            
         


        
   

