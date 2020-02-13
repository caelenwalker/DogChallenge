using System;
using System.IO;

namespace Dog_Challenge {
    public class Dog {
            public enum Gender {
                Male,
                Female
            }
            public string name; 
            public string owner; 
            public int age;  
            public Gender gender;

            public Dog(string personName, string ownerName, int numAge, Gender dogGender) {
                name = personName;
                owner = ownerName;
                age = numAge;
                gender = dogGender;
            }

            public static string getGender(Gender gender) {
                if(gender == Gender.Male) {
                    return "His";
                }    
                else {
                    return "Her";
                }
            }

            public void Bark(int num) {
                for(int i = 0; i < num; i++) 
                    Console.WriteLine("Woof!");
            }

            public string GetTag() {
                string age1;
                if(age == 1){
                    age1 = "year";
                }
                else {
                    age1 = "years";
                }
                string hisorher = getGender(gender).ToString();
                string heorshe;
                if(hisorher == "His"){
                    heorshe = "he";
                }
                else {
                    heorshe = "she";
                }

                return "If lost, call " + owner + " " + hisorher + " name is " + name + " and " + heorshe + " is " + age + " " + age1 + " old.";
            }
            static void Main(string[] args) {
                Dog puppy = new Dog("Orion", "Shawn.", 1, Gender.Male);  
                puppy.Bark(3);
                Console.WriteLine(puppy.GetTag()); 

                Dog myDog = new Dog("Lileu", "Dale.", 4, Gender.Female);  
                myDog.Bark(1); 
                Console.WriteLine(myDog.GetTag());
        }
    }
}