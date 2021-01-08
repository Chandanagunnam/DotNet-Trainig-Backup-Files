import { Component, OnInit } from '@angular/core';
import { ContactNames } from '../models/contactnames.model';
import{NgForm} from '@angular/forms';
//import {ModalDismissReasons, NgbModal} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.css']
})
export class ContactsComponent implements OnInit {

  contactlist:ContactNames[]=[{FirstName:"Mary",LastName:"Trump",PhoneNumber:"453-888-9998"},
  {FirstName:"Peter",LastName:"Paul",PhoneNumber:"473-891-7968"},
  {FirstName:"Kevin",LastName:"Peterson",PhoneNumber:"913-188-4928"},
  {FirstName:"Jane",LastName:"Vazrane",PhoneNumber:"312-178-9921"},
  {FirstName:"Daisy",LastName:"Darwin",PhoneNumber:"312-178-9976"}
];
onEntering(phonebookform:NgForm){
  console.log(phonebookform.value)
  //this.modalService.dismissAll();
}
getcontactinfo:any={};
public searchText:any;
Message;
//closeResult:string;

  constructor(/*private modalService:NgbModal*/)
  { }
 
  addcontact(){
   
        this.contactlist.push(this.getcontactinfo);
        this.getcontactinfo={};
        alert("Contact Added Successfully")
  }
  deletecontact(fn){
    for(let i=0;i<this.contactlist.length;i++){
      if(fn == this.contactlist[i].FirstName){

    this.contactlist.splice(fn,1);
    this.Message="Contact Deleted";
  }
  else{
    this.Message="Contact not Deleted";
  }
}
}
  indexvalue;
  editcontact(fn){
    for(let i=0;i<this.contactlist.length;i++){
      if(fn == this.contactlist[i].FirstName){
        this.getcontactinfo.FirstName=this.contactlist[i].FirstName;
    this.getcontactinfo.LastName=this.contactlist[i].LastName;
    this.getcontactinfo.PhoneNumber=this.contactlist[i].PhoneNumber;
    this.indexvalue=fn;

      }
      else{
        this.Message="Not Editable";
      }
    }    

  }
  
updatecontact(){
  let fn = this.indexvalue;
  for(let i=0;i<this.contactlist.length;i++)
  {
    if(fn==this.contactlist[i].FirstName)
    {
      this.contactlist[i] = this.getcontactinfo;
      this.getcontactinfo={};
      this.Message="Contact Updated Successfully";
    }
    else{
      this.Message="Cannot Be Updated";

    }
  }

}

/*open(content) {
  this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
    this.closeResult = 'Closed with: ${result}';
  }, (reason) => {
    this.closeResult = 'Dismissed ${this.getDismissReason(reason)}';
  });
}

private getDismissReason(reason: any): string {
  if (reason === ModalDismissReasons.ESC) {
    return 'by pressing ESC';
  } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
    return 'by clicking on a backdrop';
  } else {
    return 'with: ${reason}';
  }
}*/


   
 

  ngOnInit():void{
  }

}
