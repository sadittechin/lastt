# Sadittechin Rattanaphong 683450194-7
                ┌──────────────────┐
                │      Person      │
                │   (Abstract)     │
                ├──────────────────┤
                │ - Name : string  │
                ├──────────────────┤
                │ + ShowInfo()     │
                └─────────▲────────┘
                          │
                Inheritance
                          │
        ┌─────────────────┴─────────────────┐
        │                                   │
┌──────────────────┐             ┌──────────────────┐
│      Student     │             │      Teacher     │
├──────────────────┤             ├──────────────────┤
│ - StudentID      │             │ - TeacherID      │
│ - Score          │             │ - Name           │
│ - Grade          │             ├──────────────────┤
├──────────────────┤             │ + ShowInfo()     │
│ + CalculateGrade()│            └──────────────────┘
│ + ShowInfo()      │
└─────────▲─────────┘
          │
          │
          │
     ┌────┴────────────────────┐
     │         Course          │
     ├─────────────────────────┤
     │ - CourseName : string   │
     │ - CourseID : string     │
     │ - students : List<Student> │
     ├─────────────────────────┤
     │ + AddStudent()          │
     │ + ShowStudents()        │
     │ + AverageScore()        │
     │ + MaxScore()            │
     │ + MinScore()            │
     └─────────────────────────┘
