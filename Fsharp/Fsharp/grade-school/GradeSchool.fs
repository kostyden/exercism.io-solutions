module GradeSchool

let empty = List.empty

let add name gradeNumber school = 
    (name, gradeNumber) :: school

let grade gradeNumber school = 
    school 
    |> List.filter (fun (name, number) -> number = gradeNumber) 
    |> List.map fst
    |> List.sort

let roster school = 
    school
    |> List.groupBy snd
    |> List.map (fun (grade, students) -> (grade, students |> List.map fst))

