import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vTempPstBase {

//#region media Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'media', keyColumn: false})
        media : string;
//#endregion media Prop


//#region caption Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'caption', keyColumn: false})
        caption : string;
//#endregion caption Prop


//#region message Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'message', keyColumn: false})
        message : string;
//#endregion message Prop

}