using Test;
namespace calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# METODLARI
            /*
            1) Metodlar yalnızca çağırıldığında çalışan bir yapıdır
            !!main metod dışında oluşturulan bir metod mutlaka main metod içersinde çağırılmalıdır

            2) Parametre olarak adlandırılan birimleri metodlara aktarabiliriz 
            Örn: public void Test(int deneme //Parametre);

            3)metodlar belirli eylemleri gerçekleştirmek için kullanılır 
            Aynı zamanda (Fonksiyon) olrak da bilinirler

            4) metodları kod tekrarı yapmamak için  (DRY:Dont Reapeat Yourself) kullanırız. 
            Yani kısaca bir metod içine yazılan kodları o metodların aracılığıyla tekrar  tekrar kullanmaya yarar
            
            5) Metodlar isimlendirilirken büyük harfle başlanmalıdır.
            Örn: MyMethod, TasitRengi vb.

            6) Bir metod birden fazla çağırılabilir

            7) Bir metoda birden fazla parametre tanımlanabilir 
            fakat tanımlanan sıraya göre veriler girilmelidir
            Örn:
            (string isim, int yaş)
            ("ismail",21) //DOĞRU
            (21,"ismail") //YANLIŞ

            8) Eğer kullanıcı bir bilgi girmese bile metodun
            varsayılan bir değer dödürmesini istiyorsanız
            (string isim="ismail") şeklinde parametre tanımlamalısınız
             
            9) Eğer bir metodun belirli bir veriyi geri 
            döndürmesini istiyorsak return kullanarak döndürülmesini
            istediğimiz değeri metodu oluşturuken belirtiriz
            (void geriye değer dödürülmeyeceğini belirtir bu yüzden return kullanılmaz)

            10) Parametreleri Key:Value şeklinde tanımlarsak sırası önemli değildir


            //METOD OVERLOADİNG

            -her metodun prametre verilen kısmı kendine has imzasıdır

            -aynı isimde birden çok metod tanımlamak mümkünür ve buna metod overloding denir

            -overloading işlemi aynı isimdeki metodların farklı imzalardan oluşmasıyla sağlanır

             */




            //-------------------------------------------------------------------------



            //C# OOP (Nesne Tabanlı Programlama)

            /*
             -nesne tabanlı programlamanın mantığı hem verileri hem de metodları içinde 
            bulundurabilen nesneler oluşturmaktır
            -AVANTAJLARI:

            -OOP nin çalıştırılması daha hızlı ve kolaydır
            -OOP programlar için net bir yapı sağlar
            -OOP DRY(kendini tekrar etme) önler ve kodun bakımını, 
            şeklini değiştirilmesine olanak tanır ve hata ayıklamada kolaylık sağlar
            -OOP ile yazılmış sınıfları daha az kod ve daha kısa geliştirme süresine olanak tanır
            ve bu classlar farklı projelerde tekrar tekrar kullanılabilir
            -sınıf nesnenin şablonudur ve nesne de sınıfın örneğidir
            -bir nesne oluşturulduğunda sınıfındaki tüm verileri metodları ve değişkenleri miras alır
            -sınıfın adı büyük harfle başlamalıdır (zorunlu değildir)
            -dosyanın adı ile sınıf adının aynı olması daha iyi olur (zorunlu değildir)
             
            -sataic ile oluşturulan metod o sınıfa aittir ve o sınıf 
            dışında kullanılamaz ama sınıf içersinde nesne oluşturulmadan kullanılabilir
            -bunu değiştirmek için PUBLİC olarak tanımlayabilirz 
            Public ile tanımlanan metodlara ise sadece nesneler ile erişebiliriz

            -Kapsülleme
            -kapsülleme yapabilmek için fieldlar private olrak tanımlanmalıdır
            -sınıf üyelerinin daha iyi kontrol edilmesini sağlar
            (başkalarının kodları bozmasını engeller)
            -fielflar sadece get veya set kullanılıyorsa kullanılabilir
            -kodların bir bölümünü diğer kodları etkilemeden kkolayca
            değiştirmeye yarar
            -veri güvenliği artar

            -SET:veri girişine olanak sağlar eğer set yazılmazsa kullanıcı kafasına göre
            veri girişi yapamaz
            -GET: set ile girilen verileri getirmeye yarar. set olmadan kapsülleme yapabilirz fakat get
            olmadan veriyi getiremeyiz


            -Erişim belirleyiciler
            Public:Tüm sınıflardan erişilebilen bir belirteçtir
            Private: kodlara yalnızca bulunduğu sınıf içinde erişilebilir
            Protected:Kod aynı sınıf içinde veya o sınıftan miras alınan bir sınıfta erişilebilir.
            Internal:Kod yalnızca kendi derlemesi içinde erişilebilir, ancak başka bir derlemeden erişilemez.


            -Kalıtım
            -sealed: mühürlenmis class anlamına gelir ve hiçbir class tarafından erişilemez miras alınamaz
            -yeni bir sınıf oluşturulduğunda yeniden kullanılabilecek alanlar içeren sınıftan miras alarak daha az kod yazılmasını sağlar

            -polimorfizm
            Metodların virtual(sanal) hale getirilerek override edilip
            birden fazla kullanılmasına olanak tanır

            -abstract (soyutlama)
            -Soyut sınıf: Nesne oluşturmak için kullanılamayan kısıtlı bir sınıftır
            (erişmek için başka bir sınıftan miras alınması gerekir).

            -Soyut yöntem: Yalnızca soyut bir sınıfta kullanılabilir ve gövdesi yoktur. 
            Gövde, türetilmiş sınıf (miras alınan) tarafından sağlanır.

            -güvenliği sağlamak için kullanılabilir

            -interfaceler ile de soyutlama yapılabilir

            -Interface
            -yalnızca soyut metodlar ve soyut özellikler içeren 
            tamamne soyutt bir sınıftır
            -ınterface ler field içeremez
            -ınterface olduğu anlaşılması için isimlendirme yaparken en başa 
            "I" harfi koyulur (IAnimal) gibi

            ÖRN:
            interface IAnimal 
            {
              void animalSound(); // interface method (does not have a body)
              void run(); // interface method (does not have a body)
            }

            Arayüzlerle ilgili notlar:
            -Soyut sınıflar gibi , arayüzler de nesneler oluşturmak için 
            kullanılamaz (yukarıdaki örnekte, Program sınıfında "IAnimal" nesnesi oluşturmak mümkün değildir)
            -Arayüz yöntemlerinin bir gövdesi yoktur; gövde "implement" 
            sınıfı tarafından sağlanır
            -Bir arayüzün uygulanmasında, onun tüm yöntemlerini geçersiz 
            kılmalısınız
            -Arayüzler özellikler ve yöntemler içerebilir ancak 
            alanlar/değişkenler içeremez
            -Arayüz üyeleri varsayılan olarak abstractve public
            -Bir arayüz bir kurucu içeremez (nesneler oluşturmak için 
            kullanılamadığı için)

            Arayüzler Neden ve Ne Zaman Kullanılmalı?
            1) Güvenliği sağlamak için - belirli ayrıntıları gizleyin ve
            yalnızca bir nesnenin (arayüzün) önemli ayrıntılarını gösterin.

            2) C# "çoklu kalıtımı" desteklemez (bir sınıf yalnızca bir 
            temel sınıftan miras alabilir). Ancak sınıf birden fazla arayüzü uygulayabildiği için arayüzlerle elde edilebilir . Not: Birden fazla arabirim uygulamak için bunları virgülle ayırın (aşağıdaki örneğe bakın).



            -Enum
            -sabit değiştirilemez değerleri içeren bir sınıftır
            -genellikle ay yıl gün sıralası yapılırken kullanılır
             örn:

                        enum Level 
                        {
                          Low,
                          Medium,
                          High
                        }
                 Level myVar = Level.Medium;
                 Console.WriteLine(myVar);

            -enumları sınıflar içersinde kullanabilirz

            örn: 

            class Program
            {
              enum Level
              {
                Low,
                Medium,
                High
              }
              static void Main(string[] args)
              {
                Level myVar = Level.Medium;
                Console.WriteLine(myVar);
              }
            }

            -enumlarda değerler index mantığında numaralndırılır
           örn:
            enum Months
            {
              January,    // 0
              February,   // 1
              March,      // 2
              April,      // 3
              May,        // 4
              June,       // 5
              July        // 6
            }

            static void Main(string[] args)
            {
              int myNum = (int) Months.April;
              Console.WriteLine(myNum);
            }

           -enumlarda numaralandırmayı değiştirebilirzi
            örn:

            enum Months
            {
              January,    // 0
              February,   // 1
              March=6,    // 6
              April,      // 7
              May,        // 8
              June,       // 9
              July        // 10
            }

            static void Main(string[] args)
            {
              int myNum = (int) Months.April;
              Console.WriteLine(myNum);
            }

            -Enums Neden ve Ne Zaman Kullanılmalı?
            Ay günleri, günler, renkler, kart destesi vb. gibi değişmeyeceğini bildiğiniz 
            değerleriniz olduğunda numaralandırmaları kullanın.


             */



            //MyMethod Metodunu Main Metotta çalıştırırz
            //MyMethod();


            //Multi Calling Methods
            //MyMethod();
            //MyMethod();
            //MyMethod();

            //Argümanları girmek
            //MyMethod("Liam");
            //MyMethod("Jenny");  //argüman
            //MyMethod("Anja");

            //çoklu argüman girmek
            //MyMethod("Liam", 5);
            //MyMethod("Jenny", 8);
            //MyMethod("Anja", 31);

            //varsayılan değeri olan metodu çağırma
            //MyMethod("Sweden");
            //MyMethod("India");
            //MyMethod();              //Normalde argüman tanımlanmadığı için hata vermesi gerekirdi
            //                         //ama varsıyalan değer olduğu için düzgün çalıştı
            //MyMethod("USA");

            //return değeri olan metoda veri girmek
            //Console.WriteLine(MyMethod(3)); //böyle yazmak yerime metodu bir değişkene atayabiliriz

            //int x= MyMethod(4);
            //Console.WriteLine(x);

            //Key:value şeklinde olan parametrelere veri girme
            //MyMethod(child3: "John", child1: "Liam", child2: "Liam");

            //metod overloading veri girişi
            //int myNum1 = PlusMethod(8, 5);
            //double myNum2 = PlusMethod(4.3, 6.26);
            //Console.WriteLine("Int: " + myNum1);
            //Console.WriteLine("Double: " + myNum2);








            //----------------------------------------------------------------------





            //sınıftan nesne oluşturma örneği (PUBLİC DEĞİŞKEN SAYESİNDE)
            //Car myObj = new Car();
            //Console.WriteLine(myObj.color);

            //kalıtımla oluşturulmuş örnek
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);


            //override edilmiş metod kullanan kod
            //Animal myAnimal = new Animal();  // Create a Animal object
            //Animal myPig = new Pig();  // Create a Pig object
            //Animal myDog = new Dog();  // Create a Dog object

            //myAnimal.animalSound();
            //myPig.animalSound();
            //myDog.animalSound();


            ////abstract classlardan üretilmiş nesneler
            //Pig myPig = new Pig(); // Create a Pig object
            //myPig.animalSound();  // Call the abstract method
            //myPig.sleep();  // Call the regular method


            //Interface kullanılarak üretilmiş nesne
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();

        }


        //örnek MyMethod Metodu
        //static void MyMethod()
        //{
        //    Console.WriteLine("I just got executed!");
        //}

        //örnek prametreler kullanarak metod oluşturma
        //static void MyMethod(string fname) //parametre
        //{
        //    Console.WriteLine(fname + " Refsnes");
        //}

        //örnek birden fazla parametre ile metod oluşturma
        //static void MyMethod(string fname, int age)
        //{
        //    Console.WriteLine(fname + " is " + age);
        //}
        //örnek varsayılan bir parametresi olan metodu tanımlama
        //static void MyMethod(string country = "Türkiye")
        //{
        //    Console.WriteLine(country);
        //}

        //geri dönüş tipi int olan metod
        //static int MyMethod(int x)
        //{
        //    return 5 + x;
        //}

        ////key::value şeklinde parameteresi olan metodlar
        //static void MyMethod(string child1, string child2, string child3)
        //{
        //    Console.WriteLine("The youngest child is: " + child3);

        //örnek metod overloading
        //static int PlusMethod(int x, int y)
        //{
        //    return x + y;
        //}

        //static double PlusMethod(double x, double y)
        //{
        //    return x + y;
        //}








    }


    //class oluşturma örneği
    //class Car
    //{
    //    string color = "red";
    //    static void Main(string[] args)
    //    {
    //        //sınıftan nesne oluşturma örneği
    //        Car myObj = new Car();
    //        Console.WriteLine(myObj.color);
    //    }
    //}


    //başka bir main metodu içinde kullanabilmek için verileri PUBLİC olaraktanımlarız
    //class Car
    //{
    //    public string color = "red";
    //}


    //class içinde bulunan üyeler
    class MyClass
    {
        // Class members
        string color = "red";        // field
        int maxSpeed = 200;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    //field kullanma
    //class Car
    //{
    //    //fieldların değerleri boş bırakılabilir
    //    //nesne oluşturulduğunda fielda değer atanabilir
    //    string color = "red";
    //    int maxSpeed = 200;

    //    static void Main(string[] args)
    //    {
    //        Car myObj = new Car();
    //        Console.WriteLine(myObj.color);
    //        Console.WriteLine(myObj.maxSpeed);
    //    }
    //}

    //esnek bir field kullanma örneği
    //class Car
    //{
    //    string model;
    //    string color;
    //    int year;

    //    static void Main(string[] args)
    //    {
    //        Car Ford = new Car();
    //        Ford.model = "Mustang";
    //        Ford.color = "red";
    //        Ford.year = 1969;

    //        Car Opel = new Car();
    //        Opel.model = "Astra";
    //        Opel.color = "white";
    //        Opel.year = 2005;

    //        Console.WriteLine(Ford.model);
    //        Console.WriteLine(Opel.model);
    //    }
    //}


    //Kalıtım örneği
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }


    //class Animal  // Base class (parent) 
    //{
    //    public virtual void animalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Pig : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Dog : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The dog says: bow wow");
    //    }
    //}


    //bu classtan nesne oluşturulamaz ancak miras alan classlar nesne oluşturabilir
    //abstract class Animal
    //{
    //    public abstract void animalSound();
    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }
    //}

    //bunu şu şekilde kullanabilirz

    // Abstract class
    //abstract class Animal
    //{
    //    // Abstract method (does not have a body)
    //    public abstract void animalSound();
    //    // Regular method
    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }
    //}

    //// Derived class (inherit from Animal)
    //class Pig : Animal
    //{
    //    public override void animalSound()
    //    {
    //        // The body of animalSound() is provided here
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}


    //Interface örneği


    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }








}