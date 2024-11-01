          +------------------+
          |      Program     |
          +------------------+
          | + Main(args)     |
          +------------------+
                 |
                 | creates
                 v
          +---------------------+
          |   Assignment        |
          +---------------------+
          | - _studentName      |
          | - _topic            |
          +-----------------------------+
          | + Assignment(...)           |
          | + GetStudentName()          |
          | + GetTopic()                |
          | + GetSummary()              |
          +-----------------------------+
                 ^                    ^
                 |                    |
          +---------------------+    +---------------------+
          |   MathAssignment    |    |  WritingAssignment  |
          +---------------------+    +---------------------+
          | - _textbookSection  |    | - _title            |
          | - _problems         |    +---------------------------+
          +-----------------------+  | + WritingAssignment(...)  |
          | + MathAssignment(...) |  | + GetWritingInformation() |
          | + GetHomeworkList()   |  +---------------------------+
          +-----------------------+  
