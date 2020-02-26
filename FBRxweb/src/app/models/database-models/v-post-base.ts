import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vPostBase {

//#region firstName Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region caption Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'caption', keyColumn: false})
        caption : string;
//#endregion caption Prop


//#region comment Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'comment', keyColumn: false})
        comment : string;
//#endregion comment Prop


//#region media Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'media', keyColumn: false})
        media : string;
//#endregion media Prop


//#region createdDateTime Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'createdDateTime', keyColumn: false})
        createdDateTime : any;
//#endregion createdDateTime Prop

}