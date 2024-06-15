string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;

// CALCULATE GPA
int total_credit_hours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

float GPA = (course1Grade * course1Credit + course2Grade * course2Credit + course3Grade * course3Credit + course4Grade * course4Credit + course5Grade * course5Credit) / (float)total_credit_hours; 

// rounding
float rounded_GPA_remainder = ((GPA * 100) % 1) / 100;


// OUTPUT
Console.WriteLine("Student : " + studentName);

Console.WriteLine(@$"
Course               Grade       Credit Hours
{course1Name}             {course1Grade}            {course1Credit}
{course2Name}             {course1Grade}            {course1Credit}
{course3Name}             {course1Grade}            {course1Credit}
{course4Name}             {course1Grade}            {course1Credit}
{course5Name}             {course1Grade}            {course1Credit}

FINAL GPA :         {GPA - rounded_GPA_remainder}

");
Console.WriteLine((GPA * 100) % 1);
Console.ReadLine();











