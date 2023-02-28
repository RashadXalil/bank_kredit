loginbp:
Console.Write("username: ");
string username = Console.ReadLine();
Console.Write("Password: ");
string password = Console.ReadLine();
if(username == "admin" &&  password == "admin")
{
    menubp:
    Console.WriteLine("1.Kredit goturmek \n2.Kredit odemek \n3.Hesabat");
    Console.Write("Emeliyyat: ");
    string emeliyyat = Console.ReadLine();
    float odenilecek_mebleg = 0;
    float ayliq_odenis = 0;
    switch (emeliyyat)
    {
        case "1":
            Console.Write("Ayi daxil edin : ");
            int ay = Int32.Parse(Console.ReadLine());
            Console.Write("Meblegi daxil edin:");
            int mebleg = Int32.Parse(Console.ReadLine());
            if (ay <= 12)
            {
                 odenilecek_mebleg = mebleg + (mebleg * 0.12f);
                ayliq_odenis = odenilecek_mebleg / ay;
            }
            else
            {
                 odenilecek_mebleg = mebleg + (mebleg * 0.18f);
                ayliq_odenis = odenilecek_mebleg / ay;
            }
            Console.WriteLine($"odeyeceyiniz umumi mebleg: {odenilecek_mebleg} AZN\nAyliq odenis : {ayliq_odenis} AZN");
            Console.WriteLine("Krediti goturmek istiyirsinizmi ? 1.Yes 2.No");
            string choise = Console.ReadLine();
            if (choise == "1")
            {
                Console.WriteLine("Emeliyyat ugurlu oldu !");
                Console.WriteLine($"Sizin cari borcunuz  {odenilecek_mebleg} AZN\nAyliq odenisiniz: {ayliq_odenis} AZN");
                goto menubp;
            }
            else
            {
                Console.WriteLine("Emeliyyat ugursuz oldu !");
                goto menubp;

            }

            break;
        case "2":
            Console.WriteLine("kredit odemek");
            break;
        case "3":
            Console.WriteLine("hesabat");
            break;
        default:
            Console.WriteLine("Daxil etdiyiniz emeliyyat movcud deyil !");
            break;
    }
}
else
{
    Console.WriteLine("melumatlar duzgun deyil !");
    goto loginbp;
}