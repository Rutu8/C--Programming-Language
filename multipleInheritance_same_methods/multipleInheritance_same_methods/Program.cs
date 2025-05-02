using multipleInheritance_same_methods;

//You make which referrence that will print
Employee emp = new Employee();
emp.show();
emp.show();

Person person = new Person();
person.show();

Iteacher teacher = new Employee();//you can create object of parent class or interface under child
teacher.show();

Person p = new Employee();//you can create object of parent class or interface under child
p.show();


//Iteacher teacher = new();//cannot create an istance of the abstract type or interface 'Iteacher'
//teacher.show();