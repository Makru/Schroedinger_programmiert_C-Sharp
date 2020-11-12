using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Polymorphismus {

    class A {
        public virtual void DoA() {
            Console.WriteLine("A: DoA");
        }
        public virtual void DoA1() {
            Console.WriteLine("A: DoA1");
        }
        public virtual void DoA2() {
            Console.WriteLine("A: DoA2");
        }
    }
    class B : A {
        public override void DoA() {
            Console.WriteLine("B: DoA");
        }
        public new void DoA1() {
            Console.WriteLine("B: DoA1");
        }
        public void DoB() {
            Console.WriteLine("B: DoB");
        }
        public virtual void DoB1() {
            Console.WriteLine("B: DoB1");
        }
    }
    class C : B {
        public override void DoA() {
            Console.WriteLine("C: DoA");
        }
        public override void DoB1() {
            Console.WriteLine("C: DoB1");
        }
        public void DoC() {
            Console.WriteLine("C: DoC");
        }
    }


    class Program {
        static void Main(string[] args) {
            Console.WriteLine("A myA = new A();");
            A myA = new A();
            myA.DoA();
            myA.DoA1();
            myA.DoA2();
            Console.WriteLine("A myAB = new B();");
            A myAB = new B();
            myAB.DoA();
            myAB.DoA1();
            myAB.DoA2();
            Console.WriteLine("A myAC = new C();");
            A myAC = new C();
            myAC.DoA();
            myAC.DoA1();
            myAC.DoA2();

            Console.WriteLine("B myB = new B();");
            B myB = new B();
            myB.DoA();
            myB.DoA1();
            myB.DoA2();
            myB.DoB();
            myB.DoB1();

            Console.WriteLine("B myBC = new C();");
            B myBC = new C();
            myBC.DoA();
            myBC.DoA1();
            myBC.DoA2();
            myBC.DoB();
            myBC.DoB1();

            Console.WriteLine("C myA = new C();");
            C myC = new C();
            myC.DoA();
            myC.DoA1();
            myC.DoA2();
            myC.DoB();
            myC.DoB1();
            myC.DoC();
        }
    }
}
