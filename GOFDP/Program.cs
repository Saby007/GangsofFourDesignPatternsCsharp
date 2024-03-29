using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";

            do
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("1. Creation Pattern");
                Console.WriteLine("2. Structural Pattern");
                Console.WriteLine("3. Behavioural Pattern");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Please Enter your response :");
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("1. Abstract Factory");
                        Console.WriteLine("2. Builder");
                        Console.WriteLine("3. Factory Method");
                        Console.WriteLine("4. Prototype");
                        Console.WriteLine("5. Singleton");
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Please Enter your response :");
                        response = Console.ReadLine();
                        switch (response)
                        {
                            case "1":
                                Console.WriteLine("Abstract Factory Pattern ..........");
                                CreationalPatterns.AbstractFactory.Orchastrator instance = new CreationalPatterns.AbstractFactory.Orchastrator();
                                break;
                            case "2":
                                Console.WriteLine("Builder Pattern...........");
                                new CreationalPatterns.BuilderPattern.BuilderOrchastrator();
                                break;
                            case "5":
                                Console.WriteLine("Singleton Sample..........");
                                CreationalPatterns.Singleton.SingletonSample instance1 = CreationalPatterns.Singleton.SingletonSample.Instacnce;
                                instance1.addCount();
                                Console.WriteLine("Instance Count for instance1= " + instance1.Count);
                                CreationalPatterns.Singleton.SingletonSample instance2 = CreationalPatterns.Singleton.SingletonSample.Instacnce;
                                instance2.addCount();
                                Console.WriteLine("Instance Count for instance1= " + instance1.Count + " & instance2 = "+instance2.Count);
                                break;
                        }

                        break;
                    case "2":
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("1. Adapter");
                        Console.WriteLine("2. Bridge");
                        Console.WriteLine("3. Composite");
                        Console.WriteLine("4. Decorator");
                        Console.WriteLine("5. Facade");
                        Console.WriteLine("6. Flyweight");
                        Console.WriteLine("7. Proxy");
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Please Enter your response :");
                        response = Console.ReadLine();
                        switch (response)
                        {
                            case "1":
                                Console.WriteLine("Adapter Pattern...........................");
                                StructuralPatterns.AdapterPattern.AdapterOrchastrator instance  = new StructuralPatterns.AdapterPattern.AdapterOrchastrator();
                                break;
                            case "2":
                                Console.WriteLine("Bridge Pattern...............................");
                                StructuralPatterns.BridgePattern.BridgeOrchastrator bridgeInstance = new StructuralPatterns.BridgePattern.BridgeOrchastrator();
                                bridgeInstance.executor();
                                break;
                            case "7":
                                Console.WriteLine("Proxy Pattern..................................");
                                new StructuralPatterns.ProxyPattern.ProxyOrchastrator();
                                break;                           
                        }
                        break;
                    case "3":
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("1. Chain of Responsibility");
                        Console.WriteLine("2. Command");
                        Console.WriteLine("3. Interpreter");
                        Console.WriteLine("4. Iterator");
                        Console.WriteLine("5. Mediator");
                        Console.WriteLine("6. Memento");
                        Console.WriteLine("7. Observer");
                        Console.WriteLine("8. State");
                        Console.WriteLine("9. Strategy");
                        Console.WriteLine("10. Template");
                        Console.WriteLine("11. Visitor");
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Please Enter your response :");
                        response = Console.ReadLine();
                        switch (response)
                        {
                            case "3":
                                Console .WriteLine("Interpreter Pattern Example");
                                new BehavioralPatterns.InterpreterPattern.RunExample();
                                break;
                        }
                        break;
                }
                Console.WriteLine("Do you want to Continue");
                response = Console.ReadLine();
            } while (response == "y");





        }
    }
}
