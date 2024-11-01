/* 
-------------------------------------------------------------Program Diagram-----------------------------------------------------------

        +-------------------+
        |      Activity     |
        +-----------------------+
        | - Name: string        |
        | - Description: string |
        | - Duration: int       |
        +-------------------------------------+
        | + SetName(name)                     |
        | + SetDescription(description)       |
        | + SetDuration(duration)             |
        | + GetDuration(): int                |
        | + GetFutureTime(duration): DateTime |
        | + GenerateSpinner(duration): void   |
        +-------------------------------------+
                ^
                |
                +------------------------------------------+
                |                                          |
        +-------------------+                              +---------------------+
        | BreathingExercise |                              | ReflectingActivity  |
        +-------------------+                              +----------------------------+
        |                   |                              | - _prompts: List<string>   |
        |                   |                              | - _questions: List<string> |
    +-----------------------------------+                  +----------------------------+
    | + StartBreathingExercise()        |
    | + GenerateCountdownTimer(seconds) |
    +-----------------------------------+     
              | 
    +------------------------------+         
    | + GeneratePrompt(): string   |
    | + GenerateQuestion(): string |
    | + PromptReflecting(): void   |
    +------------------------------+
                |
        +--------------------+
        | ListingActivity    |
        +--------------------------+
        | - _prompts: List<string> |
        +----------------------------+
        | + GeneratePrompt(): string |
        | + PromptListing(): void    |
        +----------------------------+
*/