// Top level program

#region Only If Statement - Practice 1
/*
 * 1) Use the if statement to print "Hello World" with the condition that it is always true
 */

using System.Collections.Specialized;

if (true) Console.Write("HELLO WORLD!");
Console.WriteLine("\n--------");

#endregion


#region If-Else Statement and Ternary Conditional Operator  - Practice 2
/*
 * 2) Check if 3 points (2, 0), (3, 1), (1, -1) are collinear by using if/else statement and ternary conditional operator.
 * 
 * A(x1, y1), B(x2, y2), C(x3, y3)
 * 
 * Vector AB = (x2 - x1, y2 - y1)
 * Vector BC = (x3 - x2, y3 - y2)
 * 
 * x2 - x1   y2 - y1
 * ------- = -------  
 * x3 - x2   y3 - y2
 * 
 * => (x2 - x1) * (y3 - y2) = (y2 - y1) * (x3 - x2 )
 * => (x2 - x1) * (y3 - y2) - (y2 - y1) * (x3 - x2 ) = 0
 * 
 */
(int x1, int y1) a = (2, 0);  //A(x1,y1) 
(int x2, int y2) b = (3, 1);  //B(x2,y2) 
(int x3, int y3) c = (1, -1); //C(x3,y3) 

int result = (b.x2 - a.x1) * (c.y3 - b.y2) - (b.y2 - a.y1) * (c.x3 - b.x2);
//Use if/else statement
if (result == 0)
    Console.WriteLine($"{a}, {b}, {c} are collinear");
else
    Console.WriteLine($"{a}, {b}, {c} are not collinear");

//Use ternary conditional operator
Console.WriteLine($"{a}, {b}, {c} are {(result == 0 ? string.Empty : "not")}colliner");
Console.WriteLine("\n--------");

#endregion


#region Nested If-Else Statement and Nested Ternary Conditional Operator  - Practice 3
/*
 * 3) A student has the following scores: 10 points in math, 8 points in physics, 6 points in chemistry, 4 points in literature, and 7 points in English.
 * Calculate the average score and grade the academic performance according to the following criteria: 
 * - score >= 9: Excellent
 * - score >= 8: Very Good
 * - score >=6.5: Good
 * - score >= 5: Average
 * - score >=4: Pass
 * - score < 4: Failed
 */

float
    math = 10f,
    physics = 8f,
    chemistry = 6f,
    literature = 4f,
    english = 7f;

float averageScore = (math + physics + chemistry + literature + english) / 5;
Console.WriteLine($"Average score: {averageScore}");
//Use nested if/else statement
if (averageScore >= 9f)
{
    Console.WriteLine($"Grade: Excellent");
}
else if (averageScore >= 8f)
{
    Console.WriteLine($"Grade: Very good");
}
else if (averageScore >= 6.5f)
{
    Console.WriteLine($"Grade: Good");
}
else if (averageScore >= 5f)
{
    Console.WriteLine($"Grade: Pass");
}
else if (averageScore >= 4f)
{
    Console.WriteLine($"Grade: Average");
}
else
{
    Console.WriteLine($"Grade: Failed");
}
Console.WriteLine("--------");
#endregion


#region Pattern Matching - Type Pattern - Delacration Pattern
/*
 * void Function(object value)
 * - if value is null   =>                         => print warning
 * - if value is string => if value start with "M" => print value
 * - if value is int    => if value >= 18          => print value
 * - if value is bool   => if value is true        => print value
 */

object
    nullObject = null,
    nameObject = "Manh",
    ageObject = 18,
    genderObject = true;

#region Type Pattern History Version 1
void TypePatternHistoryV1(object value)
{
    if (value == null)
    {
        Console.WriteLine("value is null");
    }
    else if (value.GetType() == typeof(string))
    {
        string name = (string)value;

        if (name.StartsWith("M"))
            Console.WriteLine($"Name: {name}");
    }
    else if (value.GetType() == typeof(int))
    {
        int age = (int)value;

        if (age >= 18)
            Console.WriteLine($"Age: {age}");
    }
    else if (value.GetType() == typeof(bool))
    {
        bool gender = (bool)value;
        if (gender is true)
            Console.WriteLine($"Gender is Male");
    }
}
Console.WriteLine("\n----Type Pattern History Version 1----");
TypePatternHistoryV1(nullObject);
TypePatternHistoryV1(nameObject);
TypePatternHistoryV1(ageObject);
TypePatternHistoryV1(genderObject);
#endregion


#region Type Pattern History Version 2
void TypePatternHistoryV2(object value)
{
    string? name = value as string;
    int? age = value as int?;
    bool? gender = value as bool?;

    if (value == null)
    {
        Console.WriteLine("Value is null");
    }
    else if (name != null && name.StartsWith("M"))
    {
        Console.WriteLine($"Name = {name}");
    }
    else if (age != null && age >= 18)
    {
        Console.WriteLine($"Age = {age}");
    }
    else if (gender != null && (bool)gender)
    {
        Console.WriteLine($"Gender = Male");
    }
}
Console.WriteLine("\n----Type Pattern History Version 2----");
TypePatternHistoryV2(nullObject);
TypePatternHistoryV2(nameObject);
TypePatternHistoryV2(ageObject);
TypePatternHistoryV2(genderObject);
#endregion


#region Type Pattern With "is" Pattern Expression

void TypePatternWithIsPatternExpression(object value)
{
    if (value is null)
        Console.WriteLine("Value is null");

    else if (value is string)
    {
        string name = value as string;
        if (name.StartsWith("M"))
            Console.WriteLine($"Name: {name}");
    }
    else if (value is int)
    {
        int? age = value as int?;
        if (age >= 18)
            Console.WriteLine($"Age: {age}");

    }
    else if (value is bool)
    {
        bool? gender = value as bool?;
        if ((bool)gender)
            Console.WriteLine($"Gender: Male");
    }
}
Console.WriteLine("\n----Type Pattern With 'is' Pattern Expression----");
TypePatternWithIsPatternExpression(nullObject);
TypePatternWithIsPatternExpression(nameObject);
TypePatternWithIsPatternExpression(ageObject);
TypePatternWithIsPatternExpression(genderObject);
#endregion


#region Type Pattern With "is" Pattern Expression and Delacration Pattern
void TypePatternWithIsPatternExpressionAndDeclarationPattern(object value)
{
    if (value is null)
        Console.WriteLine("Value is null");
    else if (value is string name && name.StartsWith("M"))
        Console.WriteLine($"Name = {name}");
    else if (value is int age && age >= 18)
        Console.WriteLine($"Age is {age}");
    else if (value is bool gender)
        Console.WriteLine($"Gender = Female");
}
Console.WriteLine("\n----Type Pattern With 'is' Pattern Expression And Declaration Pattern----");

TypePatternWithIsPatternExpressionAndDeclarationPattern(nullObject);
TypePatternWithIsPatternExpressionAndDeclarationPattern(nameObject);
TypePatternWithIsPatternExpressionAndDeclarationPattern(ageObject);
TypePatternWithIsPatternExpressionAndDeclarationPattern(genderObject);
#endregion
#endregion


#region Pattern Matching - Logical Pattern - Parenthesized pattern  - Practice 4
/*
 * 4) In a class of 45 students, each student will be assigned a number between 1 and 45 that does not overlap. 
 * The teacher needed to divide into groups for activities, so he divided the number of each student by 9, the remainder of the division was the criterion to arrange the students in groups as follows:
 * - Group 1: (0, 3, 6)
 * - Group 2: (1, 4, 7)
 * - Group 3: (2, 5, 8)
 * 
 * Given the number of a student, check which group the student belongs to? (Use If-Else statement to solve this problems)
 */
void GroupByV1(int number)
{
    int remainder = number % 9;
    int group = remainder % 3 + 1;

    Console.WriteLine($"Student with number {number,2} is arrange into group {group}");
}
Console.WriteLine("\n----Logical Pattern and Declaration Pattern version 1----");
for (int i = 1; i <= 12; i++)
    GroupByV1(i);

void GroupByV2(int number)
{
    int remainder = number % 9;
    string template = "Student with number {0} is arrange into group {1}";

    if (remainder == 0 || remainder == 6 || remainder == 3)
    {
        Console.WriteLine(template, number, 1);
    }
    if (remainder == 1 || remainder == 4 || remainder == 7)
    {
        Console.WriteLine(template, number, 2);
    }
    else
    {
        Console.WriteLine(template,number, 3);
    }
}

Console.WriteLine("\n----Logical Pattern and Declaration Pattern version 2----");
for (int i = 1; i <= 12; i++)
    GroupByV2(i);

void GroupByV3(int number)
{
    int remainder = number % 9;
    string template = "Student with number {0} is arrange into group {1}";

    if (remainder is 0 or 3 or 6)
    {
        Console.WriteLine(template, number, 1);
    }
    if (remainder is 1 or 4 or 7)
    {
        Console.WriteLine(template, number, 2);
    }
    else
    {
        Console.WriteLine(template, number, 3);
    }
}

Console.WriteLine("\n----Logical Pattern and Declaration Pattern version 3----");
for (int i = 1; i <= 12; i++)
    GroupByV3(i);

void GroupByV4(int number)
{
    int remainder = number % 9;
    string template = "Student with number {0} into group {1}";
    if (remainder is not (1 or 4 or 7 or 2 or 5 or 8))
    {
        Console.WriteLine(template, number, 1);
    }
    else if (remainder is not (2 or 5 or 8))
    {
        Console.WriteLine(template, number, 2);
    }
    else
        Console.WriteLine(template, number, 3);
}
Console.WriteLine("\n----Logical Pattern and Declaration Pattern version 4----");
for (int i = 0; i <= 12; i++)
{
    GroupByV4(i);
}

void GroupByV5(int number)
{
    int remainder = number % 9;
    string template = "Student with number {0} into group {1}";

    if (remainder is not 1 and not 4 and not 7 and not 2 and not 5 and not 8)
    {
        Console.WriteLine(template, number, 1);
    }
    else if (remainder is not 2 and not 5 and not 8)
    {
        Console.WriteLine(template, number, 2);
    }
    else
        Console.WriteLine(template, number, 3);
}
Console.WriteLine("\n----Logical Pattern and Declaration Pattern version 5----");
for (int i = 1; i <= 12; i++)
    GroupByV5(i);
#endregion


#region Pattern Matching - Relational Pattern (<, > , <=, >=) - Practice 5
/*
 * 5) Men New European System Clothing Standard Body Measurements
 *             |   XS    ||    S    ||     M     ||     L     ||     XL    |
 * bust girth  | 78 - 82 || 86 - 90 ||  94 - 98  || 102 - 107 || 107 - 113 |    
 * waist girth | 62 - 66 || 70 - 74 ||  78 - 82  ||  86 - 91  ||  91 - 97  |
 * hip girth   | 86 - 90 || 94 - 98 || 102 - 106 || 110 - 115 || 115 - 120 |
 *
 * With a man's bust girth, waist girth and- hip girth figures, help him choose the right shirt size. (Use  Relational Pattern to solve this problems)
 */
#endregion