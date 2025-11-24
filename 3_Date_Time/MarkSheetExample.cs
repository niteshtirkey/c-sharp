using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Date_Time {
    internal class MarkSheetExample {
        static void Main() {
            int physicMarks = 64, chemMarks = 66, mathMarks = 78, hindiMarks = 72, engMark = 65;
            int count = 0;
            int gm = 0;
            float per;
            String subject = "";
            String distinction = "";

            if((physicMarks >= 0 && physicMarks <= 100) && (chemMarks >= 0 && chemMarks <= 100) && (mathMarks >= 0 && mathMarks <= 100) && (hindiMarks >= 0 && hindiMarks <= 100) && (engMark >= 0 && engMark <= 100)) {
                if(physicMarks < 33) {
                    count++;
                    gm = physicMarks;
                    subject += " Physics ";
                }
                if(chemMarks < 33) {
                    count++;    
                    gm = chemMarks;
                    subject += " Chemistry ";
                }
                if(hindiMarks < 33) {
                    count++;
                    gm = hindiMarks;
                    subject += " Hindi ";
                }
                if(mathMarks < 33) {
                    count++;
                    gm = mathMarks;
                    subject += " Math ";
                }
                if(engMark < 33) {
                    count++;
                    gm = engMark;
                    subject += " English ";
                }

                if(physicMarks >= 75) {
                    distinction += " Physics ";
                }
                if(chemMarks >= 75) {
                    distinction += " Chemistry ";
                }
                if(hindiMarks >= 75) {
                    distinction += " Hindi ";
                }
                if(mathMarks >= 75) {
                    distinction += " Math ";
                }
                if(engMark >= 75) {
                    distinction += " English ";
                }

                if(count == 0 || (count == 1 && gm >= 28)) {
                    if(count == 0) {
                        per = (physicMarks + chemMarks + engMark + mathMarks + hindiMarks) / 5;
                    } else {
                        per = (physicMarks + chemMarks + engMark + mathMarks + hindiMarks + (33 - gm)) / 5;
                    }
                    if(per >= 33 && per < 45) {
                        Console.WriteLine("Pass with  Third division and percentage is " + per + "%");
                    } else if(per < 60) {
                        Console.WriteLine("Pass with  Second division and percentage is " + per + "%");
                    } else {
                        Console.WriteLine("Pass with  First division and percentage is " + per + "%");
                    }

                    if(count == 1) {
                        Console.WriteLine("Pass by Grace and grace subject is : " + subject);
                    }

                    if(distinction != "") {
                        Console.WriteLine("Distinction Subject are " + distinction);
                    }
                } else if(count == 1) {
                    Console.WriteLine("Supply subject is : " + subject);
                } else {
                    Console.WriteLine("Fail");
                    Console.WriteLine("Fail subject are : " + subject);
                }
            } else {
                Console.WriteLine("Invalid Marks, it should be between 0 to 100");
            }
        }
    }
}
