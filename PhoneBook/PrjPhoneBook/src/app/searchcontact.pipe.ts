import{ Pipe } from "@angular/core";
import {PipeTransform} from "@angular/core";

@Pipe({
    name:'contactfilterpipe' 
})

export class contactfilterpipe implements PipeTransform {
transform(contactlist: any,searchText: any){
    if (searchText)
        return contactlist.filter(x=>x.FirstName.toLowerCase().startsWith(searchText.toLowerCase()));

    return contactlist;
}

}