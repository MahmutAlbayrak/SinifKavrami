internal class Program
{
    private static void Main(string[] args)
    {
        //Söz Dizimi
        // class SinifAdi
        // {
        //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
        //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi([Parametre Listesi])
        //      {
        //      //Metot Komutları
        //      }
        // }   

        //Erişim Belirleyiciler
        // * Public     : Heryerden erişilebilir 
        // * Private    : Sadece tanımlandığı sınıf içinde erişilebilir
        // * Internal   : Sadece kendi bulunduğu proje içinde erişilebilir
        // * Protected  : Sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan diğer sınıflar

        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Ayse";
        calisan1.Soyad = "Kara";
        calisan1.No = 23456987;
        calisan1.Departman = "İnsan Kaynakları";
        calisan1.CalisanBilgileri();
        Console.WriteLine("*******************");

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";
        calisan2.No = 54879564;
        calisan2.Departman = "Satın Alma";
        calisan2.CalisanBilgileri();

    }

}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı:{0}",Ad);
        Console.WriteLine("Çalışan Soaydı:{0}",Soyad);
        Console.WriteLine("Çalışan Numarası:{0}",No);
        Console.WriteLine("Çalışan Departman:{0}",Departman);
    }        
}