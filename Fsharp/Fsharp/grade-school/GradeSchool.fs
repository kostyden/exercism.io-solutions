module GradeSchool

let private name student = student |> fst

let private gradeNumber student = student |> snd

let private isGradeSameAs givenGrade student = student |> gradeNumber = givenGrade    

let private names students = students |> List.map name

let empty = List.empty

let add name gradeNumber school = 
    (name, gradeNumber) :: school

let grade gradeNumber school = 
    let isGivenGrade = isGradeSameAs gradeNumber
    school 
    |> List.filter isGivenGrade
    |> names
    |> List.sort

let roster school = 
    school
    |> List.groupBy gradeNumber
    |> List.map (fun (grade, students) -> (grade, students |> names))
    |> List.sortBy fst

