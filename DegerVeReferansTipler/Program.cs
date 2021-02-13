using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

           // int sayi1 = 10;
           // int sayi2 = 30;
           // sayi1 = sayi2;
           // sayi2 = 65;
            //sayi1= ? 30 olur

           // int[] sayilar1 = new int[] { 10, 20, 30 };
           // int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            //sayilar1[0]= ? 999  olur.

            //int,decimali float doun-ble bool= değer tip sadece değeri kopyalar ve ilişki biter olay değer ile ilgilidir.
            //array , class, interface -> referans tiptir.

            //stack değer tip olanlar burda gerçekleşir            //heap 
            //sayi1 =30 sayi1 değeri 30 dur diye okunur .

            //stack                                                            //heap
            // 101/sayilar1 tanımlanır  new dediğn zamna heapte yer açılır   ---------->         101/ [10,20,30]
            // 102/sayilar2                                                  -------------->     102/[100,200,300]         

                //ikisi de referans tip olduğu için adrsi kopyalar yani adres atar 
               // 102 n referans numarasını 101  referansı yerine atanır.
               // ve artık sayilar1 adresi referansi 102dir ve 101 referanslı arrrayı kimse tutmuyor ve garbage collection ile silinir bellekten.
        //Console.WriteLine('Sayilar[0]='+sayilar1[0]);

            Person person1=new Person();
            Person person2=new Person();
            person1.FirstName="Emine";
            person2=person1;
            person1.FirstName="Zeynep";
            //Console.WriteLine(person2.FirstName);

            Customer customer=new Customer();
            customer.FirstName="ümit";
            customer.CreditCardNumber="1234567890";
            Employee employee=new Employee();
            employee.FirstName="ela";
            Person person3=customer;
            customer.FirstName="tuğba";
          //  Console.Writeline(((Customer)person3).CreditCardNumber);

            PersonManager.Add(employee);

        }
    }
    class Person{
    public int Id { get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
    }
    //base class:Person
    class Customer:Person
        {
    public string CreditCardNumber {get;set;}
    }
    class Employee:Person{ //inheritance
    public int EmployeeNumber {get;set;}
    }
     class PersonManager{
    public void Add(Person person){
        Console.Writeline(person.FirstName);
        }
    }   
    

 