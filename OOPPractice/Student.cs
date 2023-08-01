namespace OOPPractice
{
    public class Student:User
    {
        public int Code {get; set;}
        public Student(string name, string id, int code):base(name, id){
            this.Code = code;
            this.Id = id;
            this.Name = name;
        }
    }
}