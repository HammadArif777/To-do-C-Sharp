// // using System;
// // interface IAnimal 
// // {
// //     string Sound();
// //     string Category();
// // }
// // interface ISecond{
// //      string GetName();
// // }
// // class Dog : IAnimal, ISecond
// // {
// //     public string Sound(){
// //         return "Bou Bou";
// //     }
// //     public string Category()
// //     {
// //         return "Carnivorse";
// //     }
// //     public string GetName() 
// //     {
// //         return "Hammad";
// //     }

// // }

// // using System ;
// // namespace Container 
// // {
// //   interface IFood 
// //   {
// //     string Category(string gstr);
// //   }
// //   interface IAthelete
// //   {
// //     string SportType(string str);
// //     string Role(string str);
// //     decimal Followers(decimal d);
// //   }
  
// //   public abstract class Vehicle
// //   {
// //     public abstract void CarSpec();
// //     public void Message(){
// //       Console.WriteLine("Hello World");
// //     }
  
// //   }
// //   public abstract class Animal 
// //   {
// //     public abstract void Sound();
// //     public virtual void Classification(){
      
// //     }
// //   }
// //   class Driver : Animal, IAthelete, IFood
// //   {
// //     public string type = default(string);
// //     public string role = default(string);
// //     public decimal followers = default(decimal);
// //     public string foodType = default(string);
// //     public string Category(string str){
// //         foodType = str;
// //         return foodType;
// //     }
// //     public string Role(string role){
// //         this.role = role; 
// //         return role ;
// //     }
// //     public decimal Followers(decimal followers){
// //       this.followers = followers;
// //       return followers;
// //     }
// //     public string SportType(string type){
// //       this.type = type ;
// //       return type;
// //     }
// //     public override void Sound(){
// //         Console.WriteLine("Meow Meow");
// //     }
// //     public override void Classification(){
// //       Console.WriteLine("Mammal, Carnivorse");
// //     }

// //     public static void Main(string [] args)
// //     {
// //       object driver = new Driver();
// //       ((Driver)driver).Sound();
// //       ((Driver)driver).Classification();
// //     string sports = ((Driver)driver).SportType("Cricket");
// //       decimal followers = ((Driver)driver).Followers(265.5M);
// //       string role = ((Driver)driver).Role("Right Hand Batter");
// //       string foodType = ((Driver) driver).Category("Sajji");
// //       Console.WriteLine($"{sports} {followers} {role} {foodType}");
      
// //     }
// //   }
// // }

// using System ;
// // namespace Container 
// // {
// //   abstract class Shape {
// //     public int x = 2;
// //       public abstract int Area();
// //   }
// //   class Square : Shape
// //   {
// //     public Square(int value){
// //       x = value;
// //     }
// //     public override int Area(){
// //       return x * x;
// //     }
// //   }
// //   class Rectangle : Shape 
// //   {
// //     public int y ;
// //     public Rectangle(int x, int y){
// //       this.x = x;
// //       this.y = y;
// //     }
// //     public Rectangle(int y){
// //       this.y = y;
// //     }
// //     public override int Area(){
// //       return x * y;
// //     }
// //   }
// //   class Circle : Shape {
// //     public override int Area(){
// //       return ((int)(x * 2 * 3.14));
// //     }
// //   }
// //   class MainClass 
// //   {
// //     public static void Main(string [] args){
      
// //       Shape square = new Square(2);
// //       Shape rectangle = new Rectangle(5);
// //     Shape circle = new Circle();
// //       Console.WriteLine($"{square.Area()} {rectangle.Area()} {circle.Area()}");
// //     }
// //   }
// // }
// // using System ;
// // namespace Container 
// // {
// //   class A 
// //   {
// //     public int x ;
// //     public A(){
// //       x = 10 ;
// //     }
// //   }
// //   class B 
// //   {
// //     public int y ;
// //     public B (){
// //       y = 20;
// //     }
// //     public A CreateInstanceOfA(){
// //       return new A();
// //     }
// //   }
// //   class C 
// //   {
// //     public int z ;
// //     public C (){
// //       z = 30;
// //     }
// //     public B CreateInstanceOfB(){
// //       return new B();
// //     }
// //     public C CreateInstanceOfC(){
// //       return new C();
// //     }
// //   }
// //   class MainClass 
// //   {
// //     public static void Main(string [] args){
// //       B obj_1 = new B();
// //       var objOfA= obj_1.CreateInstanceOfA();
// //       Console.WriteLine(objOfA.x);
// //     }
// //   }  
// // }




// using System;
// namespace Container 
// {
//     class MainClass 
//     {
//         public static void Main()
//         {
//             // Console.WriteLine("Press any key:");
//             // ConsoleKeyInfo key = Console.ReadKey();
//             // Console.WriteLine(key.Key);
//             // Console.WriteLine(key.KeyChar);
//             // Console.WriteLine(key.Modifiers);

//         }
//     }
// }