export class  Person {
   public code: number;
   public name: string;
   public surname: string;
   public id_number: string;
   public account_number: string;
   constructor(code:number,name:string,surname:string,id_number:string, account_number:string)
   {
    this.code = code;
    this.name = name;
    this.surname = surname;
    this.id_number = id_number;
    this.account_number = account_number;
   }
  }