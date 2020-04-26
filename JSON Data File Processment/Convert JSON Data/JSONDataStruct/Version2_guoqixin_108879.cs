using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version2_guoqixin_108879
{
    public class Rootobject
    {
        public string projectName { get; set; }
        public Repository[] repositories { get; set; }
    }

    public class Repository
    {
        public string gitUrl { get; set; }
        public Arc[] arcs { get; set; }
    }

    public class Arc
    {
        public Version version { get; set; }
        public Module[] modules { get; set; }
        public Microservice[] microservices { get; set; }
        public object[] topics { get; set; }
    }

    public class Version
    {
        public string sha { get; set; }
    }

    public class Module
    {
        public string path { get; set; }
        public string language { get; set; }
        public Package[] packages { get; set; }
    }

    public class Package
    {
        public string name { get; set; }
        public string[] dependency { get; set; }
    }

    public class Microservice
    {
        public string name { get; set; }
        public string path { get; set; }
        public object[] otherPaths { get; set; }
        public Interface[] interfaces { get; set; }
        public Call[] call { get; set; }
        public object[] publish { get; set; }
        public object[] subscribe { get; set; }
    }

    public class Interface
    {
        public string name { get; set; }
        public string[] filePaths { get; set; }
        public Inputparamstruct inputParamStruct { get; set; }
        public Outputparamstruct outputParamStruct { get; set; }
    }

    public class Inputparamstruct
    {
        public Prodinsertreq prodInsertReq { get; set; }
        public Produpdatereq prodUpdateReq { get; set; }
        public Prodqueryreq prodQueryReq { get; set; }
        public Categoryentity categoryEntity { get; set; }
        public Categoryid categoryId { get; set; }
        public Brandinsertreq brandInsertReq { get; set; }
        public Categoryqueryreq categoryQueryReq { get; set; }
        public Brandqueryreq brandQueryReq { get; set; }
        public Userid userId { get; set; }
        public File file { get; set; }
        public Id7 id { get; set; }
        public Category1 category { get; set; }
        public Parentid2 parentId { get; set; }
        public Sort2 sort { get; set; }
        public Categoryname1 categoryName { get; set; }
        public Brand2 brand { get; set; }
        public Brandlogourl1 brandLogoUrl { get; set; }
        public Companyentityid4 companyEntityId { get; set; }
        public Username username { get; set; }
        public Password password { get; set; }
        public Phone phone { get; set; }
        public Mail mail { get; set; }
        public Licencepic licencePic { get; set; }
        public Usertype userType { get; set; }
        public Registertimestart registerTimeStart { get; set; }
        public Registertimeend registerTimeEnd { get; set; }
        public Userstate userState { get; set; }
        public Roleid roleId { get; set; }
        public Orderbyregistertime orderByRegisterTime { get; set; }
        public Reqlist reqList { get; set; }
        public Menuidlist menuIdList { get; set; }
        public Permissionidlist permissionIdList { get; set; }
        public Loginreq LoginReq { get; set; }
        public Userqueryreq userQueryReq { get; set; }
        public Registerreq registerReq { get; set; }
        public Userstatereqs userStateReqs { get; set; }
        public Admincreatereq adminCreateReq { get; set; }
        public Rolemenureq roleMenuReq { get; set; }
        public Rolepermissionreq rolePermissionReq { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Keys keys { get; set; }
        public Pattern pattern { get; set; }
        public Key key { get; set; }
        public Value value { get; set; }
        public Expiretime expireTime { get; set; }
    }

    public class Prodinsertreq
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Id id { get; set; }
        public Prodname prodName { get; set; }
        public Marketprice marketPrice { get; set; }
        public Stock stock { get; set; }
        public Sales sales { get; set; }
        public Weight weight { get; set; }
        public Topcateentityid topCateEntityID { get; set; }
        public Subcategentityid subCategEntityID { get; set; }
        public Brandentityid brandEntityID { get; set; }
        public Prodstate prodState { get; set; }
        public Content content { get; set; }
        public Companyentityid companyEntityID { get; set; }
        public Shopprice shopPrice { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shopprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Produpdatereq
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
        public string name { get; set; }
    }

    public class Struct1
    {
        public Id1 id { get; set; }
        public Prodname1 prodName { get; set; }
        public Marketprice1 marketPrice { get; set; }
        public Stock1 stock { get; set; }
        public Sales1 sales { get; set; }
        public Weight1 weight { get; set; }
        public Topcateentityid1 topCateEntityID { get; set; }
        public Subcategentityid1 subCategEntityID { get; set; }
        public Brandentityid1 brandEntityID { get; set; }
        public Prodstate1 prodState { get; set; }
        public Content1 content { get; set; }
        public Companyentityid1 companyEntityID { get; set; }
    }

    public class Id1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstate1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodqueryreq
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
        public string name { get; set; }
    }

    public class Struct2
    {
        public Id2 id { get; set; }
        public Prodname2 prodName { get; set; }
        public Shoppricestart shopPriceStart { get; set; }
        public Shoppriceend shopPriceEnd { get; set; }
        public Topcategoryid topCategoryId { get; set; }
        public Subcategoryid subCategoryId { get; set; }
        public Brandid brandId { get; set; }
        public Prodstatecode prodStateCode { get; set; }
        public Companyid companyId { get; set; }
        public Orderbyprice orderByPrice { get; set; }
        public Orderbysales orderBySales { get; set; }
        public Page page { get; set; }
        public Numperpage numPerPage { get; set; }
        public Currentpage currentPage { get; set; }
    }

    public class Id2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shoppricestart
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shoppriceend
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcategoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstatecode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbyprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbysales
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Page
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Numperpage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryentity
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public Id3 id { get; set; }
        public Category category { get; set; }
        public Parentid parentId { get; set; }
        public Sort sort { get; set; }
    }

    public class Id3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandinsertreq
    {
        public string type { get; set; }
        public Struct4 _struct { get; set; }
    }

    public class Struct4
    {
        public Id4 id { get; set; }
        public Brand brand { get; set; }
        public Brandlogourl brandLogoUrl { get; set; }
        public Companyentityid2 companyEntityId { get; set; }
        public Sort1 sort { get; set; }
    }

    public class Id4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryqueryreq
    {
        public string type { get; set; }
        public Struct5 _struct { get; set; }
    }

    public class Struct5
    {
        public Id5 id { get; set; }
        public Categoryname categoryName { get; set; }
        public Parentid1 parentId { get; set; }
    }

    public class Id5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandqueryreq
    {
        public string type { get; set; }
        public Struct6 _struct { get; set; }
    }

    public class Struct6
    {
        public Id6 id { get; set; }
        public Brand1 brand { get; set; }
        public Companyentityid3 companyEntityID { get; set; }
    }

    public class Id6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class File
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimestart
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimeend
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbyregistertime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Reqlist
    {
        public string type { get; set; }
        public Struct7 _struct { get; set; }
    }

    public class Struct7
    {
        public Userid1 userId { get; set; }
        public Userstate1 userState { get; set; }
        public Phone1 phone { get; set; }
        public Mail1 mail { get; set; }
        public Licencepic1 licencePic { get; set; }
        public Registertime registerTime { get; set; }
    }

    public class Userid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuidlist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionidlist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Loginreq
    {
        public string type { get; set; }
        public Struct8 _struct { get; set; }
    }

    public class Struct8
    {
        public Username1 username { get; set; }
        public Password1 password { get; set; }
        public Phone2 phone { get; set; }
        public Mail2 mail { get; set; }
    }

    public class Username1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userqueryreq
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Id8 id { get; set; }
        public Username2 username { get; set; }
        public Password2 password { get; set; }
        public Phone3 phone { get; set; }
        public Mail3 mail { get; set; }
        public Registertimestart1 registerTimeStart { get; set; }
        public Registertimeend1 registerTimeEnd { get; set; }
        public Usertype1 userType { get; set; }
        public Userstate2 userState { get; set; }
        public Roleid1 roleId { get; set; }
        public Orderbyregistertime1 orderByRegisterTime { get; set; }
    }

    public class Id8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimestart1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimeend1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbyregistertime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registerreq
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public Username3 username { get; set; }
        public Password3 password { get; set; }
        public Phone4 phone { get; set; }
        public Mail4 mail { get; set; }
        public Licencepic2 licencePic { get; set; }
        public Usertype2 userType { get; set; }
    }

    public class Username3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstatereqs
    {
        public string type { get; set; }
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public Userid2 userId { get; set; }
        public Userstate3 userState { get; set; }
    }

    public class Userid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Admincreatereq
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
    {
        public Username4 username { get; set; }
        public Password4 password { get; set; }
        public Phone5 phone { get; set; }
        public Roleid2 roleId { get; set; }
    }

    public class Username4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolemenureq
    {
        public string type { get; set; }
        public Struct13 _struct { get; set; }
    }

    public class Struct13
    {
        public Roleid3 roleId { get; set; }
        public Menuidlist1 menuIdList { get; set; }
    }

    public class Roleid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuidlist1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolepermissionreq
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public Roleid4 roleId { get; set; }
        public Permissionidlist1 permissionIdList { get; set; }
    }

    public class Roleid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionidlist1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keys
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pattern
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Value
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiretime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
        public Issuccess1 isSuccess { get; set; }
        public Errorcode1 errorCode { get; set; }
        public Message1 message { get; set; }
        public Data1 data { get; set; }
        public Userentity2 UserEntity { get; set; }
        public string name { get; set; }
    }

    public class Struct15
    {
        public Issuccess isSuccess { get; set; }
        public Errorcode errorCode { get; set; }
        public Message message { get; set; }
        public Data data { get; set; }
        public Id9 id { get; set; }
        public Username5 username { get; set; }
        public Password5 password { get; set; }
        public Phone6 phone { get; set; }
        public Mail5 mail { get; set; }
        public Licencepic3 licencePic { get; set; }
        public Registertime1 registerTime { get; set; }
        public Usertypeenum userTypeEnum { get; set; }
        public Userstateenum userStateEnum { get; set; }
        public Roleentity roleEntity { get; set; }
        public Name1 name { get; set; }
        public Desc2 desc { get; set; }
        public Menulist1 menuList { get; set; }
        public Permissionlist1 permissionList { get; set; }
        public Permission2 permission { get; set; }
        public Menuname2 menuName { get; set; }
        public Url2 url { get; set; }
        public Parentid5 parentId { get; set; }
        public Title title { get; set; }
        public Content2 content { get; set; }
        public Userentity userEntity { get; set; }
        public Commententitylist commentEntityList { get; set; }
    }

    public class Issuccess
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Errorcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Code code { get; set; }
        public Msg msg { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Code1 code { get; set; }
        public Msg1 msg { get; set; }
    }

    public class Code1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity
    {
        public string type { get; set; }
        public Struct18 _struct { get; set; }
    }

    public class Struct18
    {
        public Id10 id { get; set; }
        public Name name { get; set; }
        public Desc desc { get; set; }
        public Menulist menuList { get; set; }
        public Permissionlist permissionList { get; set; }
    }

    public class Id10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Id11 id { get; set; }
        public Menuname menuName { get; set; }
        public Url url { get; set; }
        public Parentid3 parentId { get; set; }
    }

    public class Id11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Id12 id { get; set; }
        public Permission permission { get; set; }
        public Desc1 desc { get; set; }
    }

    public class Id12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist1
    {
        public string type { get; set; }
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Id13 id { get; set; }
        public Menuname1 menuName { get; set; }
        public Url1 url { get; set; }
        public Parentid4 parentId { get; set; }
    }

    public class Id13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist1
    {
        public string type { get; set; }
        public Struct22 _struct { get; set; }
    }

    public class Struct22
    {
        public Id14 id { get; set; }
        public Permission1 permission { get; set; }
        public Desc3 desc { get; set; }
    }

    public class Id14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userentity
    {
        public string type { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Id15 id { get; set; }
        public Username6 username { get; set; }
        public Password6 password { get; set; }
        public Phone7 phone { get; set; }
        public Mail6 mail { get; set; }
        public Licencepic4 licencePic { get; set; }
        public Registertime2 registerTime { get; set; }
        public Usertypeenum1 userTypeEnum { get; set; }
        public Userstateenum1 userStateEnum { get; set; }
        public Roleentity1 roleEntity { get; set; }
    }

    public class Id15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum1
    {
        public string type { get; set; }
        public Struct24 _struct { get; set; }
    }

    public class Struct24
    {
        public Code2 code { get; set; }
        public Msg2 msg { get; set; }
    }

    public class Code2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum1
    {
        public string type { get; set; }
        public Struct25 _struct { get; set; }
    }

    public class Struct25
    {
        public Code3 code { get; set; }
        public Msg3 msg { get; set; }
    }

    public class Code3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity1
    {
        public string type { get; set; }
        public Struct26 _struct { get; set; }
    }

    public class Struct26
    {
        public Id16 id { get; set; }
        public Name2 name { get; set; }
        public Desc4 desc { get; set; }
        public Menulist2 menuList { get; set; }
        public Permissionlist2 permissionList { get; set; }
    }

    public class Id16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist2
    {
        public string type { get; set; }
        public Struct27 _struct { get; set; }
    }

    public class Struct27
    {
        public Id17 id { get; set; }
        public Menuname3 menuName { get; set; }
        public Url3 url { get; set; }
        public Parentid6 parentId { get; set; }
    }

    public class Id17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist2
    {
        public string type { get; set; }
        public Struct28 _struct { get; set; }
    }

    public class Struct28
    {
        public Id18 id { get; set; }
        public Permission3 permission { get; set; }
        public Desc5 desc { get; set; }
    }

    public class Id18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Commententitylist
    {
        public string type { get; set; }
        public Struct29 _struct { get; set; }
    }

    public class Struct29
    {
        public Id19 id { get; set; }
        public Comment comment { get; set; }
        public Articleid articleId { get; set; }
    }

    public class Id19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Comment
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articleid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Issuccess1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Errorcode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Data1
    {
        public string type { get; set; }
        public string name { get; set; }
        public Struct30 _struct { get; set; }
        public Id43 id { get; set; }
        public Menuname9 menuName { get; set; }
        public Url9 url { get; set; }
        public Parentid15 parentId { get; set; }
    }

    public class Struct30
    {
        public Id20 id { get; set; }
        public Title1 title { get; set; }
        public Content3 content { get; set; }
        public Userentity1 userEntity { get; set; }
        public Commententitylist1 commentEntityList { get; set; }
        public Imageurl imageURL { get; set; }
        public Productid productId { get; set; }
        public Prodname3 prodName { get; set; }
        public Marketprice2 marketPrice { get; set; }
        public Shopprice1 shopPrice { get; set; }
        public Stock2 stock { get; set; }
        public Sales2 sales { get; set; }
        public Weight2 weight { get; set; }
        public Topcateentity topCateEntity { get; set; }
        public Subcategentity subCategEntity { get; set; }
        public Brandentity brandEntity { get; set; }
        public Prodstateenum prodStateEnum { get; set; }
        public Prodimageentitylist prodImageEntityList { get; set; }
        public Companyentity1 companyEntity { get; set; }
        public Category4 category { get; set; }
        public Parentid12 parentId { get; set; }
        public Sort6 sort { get; set; }
        public Brand4 brand { get; set; }
        public Brandlogourl3 brandLogoUrl { get; set; }
        public Username10 username { get; set; }
        public Password10 password { get; set; }
        public Phone11 phone { get; set; }
        public Mail10 mail { get; set; }
        public Licencepic8 licencePic { get; set; }
        public Registertime6 registerTime { get; set; }
        public Usertypeenum5 userTypeEnum { get; set; }
        public Userstateenum5 userStateEnum { get; set; }
        public Roleentity5 roleEntity { get; set; }
        public Name7 name { get; set; }
        public Desc14 desc { get; set; }
        public Menulist7 menuList { get; set; }
        public Permissionlist7 permissionList { get; set; }
        public Permission9 permission { get; set; }
    }

    public class Id20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userentity1
    {
        public string type { get; set; }
        public Struct31 _struct { get; set; }
    }

    public class Struct31
    {
        public Id21 id { get; set; }
        public Username7 username { get; set; }
        public Password7 password { get; set; }
        public Phone8 phone { get; set; }
        public Mail7 mail { get; set; }
        public Licencepic5 licencePic { get; set; }
        public Registertime3 registerTime { get; set; }
        public Usertypeenum2 userTypeEnum { get; set; }
        public Userstateenum2 userStateEnum { get; set; }
        public Roleentity2 roleEntity { get; set; }
    }

    public class Id21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity2
    {
        public string type { get; set; }
        public Struct32 _struct { get; set; }
    }

    public class Struct32
    {
        public Id22 id { get; set; }
        public Name3 name { get; set; }
        public Desc6 desc { get; set; }
        public Menulist3 menuList { get; set; }
        public Permissionlist3 permissionList { get; set; }
    }

    public class Id22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist3
    {
        public string type { get; set; }
        public Struct33 _struct { get; set; }
    }

    public class Struct33
    {
        public Id23 id { get; set; }
        public Menuname4 menuName { get; set; }
        public Url4 url { get; set; }
        public Parentid7 parentId { get; set; }
    }

    public class Id23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist3
    {
        public string type { get; set; }
        public Struct34 _struct { get; set; }
    }

    public class Struct34
    {
        public Id24 id { get; set; }
        public Permission4 permission { get; set; }
        public Desc7 desc { get; set; }
    }

    public class Id24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Commententitylist1
    {
        public string type { get; set; }
        public Struct35 _struct { get; set; }
    }

    public class Struct35
    {
        public Id25 id { get; set; }
        public Comment1 comment { get; set; }
        public Articleid1 articleId { get; set; }
    }

    public class Id25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Comment1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articleid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imageurl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shopprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentity
    {
        public string type { get; set; }
        public Struct36 _struct { get; set; }
    }

    public class Struct36
    {
        public Id26 id { get; set; }
        public Category2 category { get; set; }
        public Parentid8 parentId { get; set; }
        public Sort3 sort { get; set; }
    }

    public class Id26
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentity
    {
        public string type { get; set; }
        public Struct37 _struct { get; set; }
    }

    public class Struct37
    {
        public Id27 id { get; set; }
        public Category3 category { get; set; }
        public Parentid9 parentId { get; set; }
        public Sort4 sort { get; set; }
    }

    public class Id27
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentity
    {
        public string type { get; set; }
        public Struct38 _struct { get; set; }
    }

    public class Struct38
    {
        public Id28 id { get; set; }
        public Brand3 brand { get; set; }
        public Brandlogourl2 brandLogoUrl { get; set; }
        public Companyentity companyEntity { get; set; }
        public Sort5 sort { get; set; }
    }

    public class Id28
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity
    {
        public string type { get; set; }
        public Struct39 _struct { get; set; }
    }

    public class Struct39
    {
        public Id29 id { get; set; }
        public Username8 username { get; set; }
        public Password8 password { get; set; }
        public Phone9 phone { get; set; }
        public Mail8 mail { get; set; }
        public Licencepic6 licencePic { get; set; }
        public Registertime4 registerTime { get; set; }
        public Usertypeenum3 userTypeEnum { get; set; }
        public Userstateenum3 userStateEnum { get; set; }
        public Roleentity3 roleEntity { get; set; }
    }

    public class Id29
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity3
    {
        public string tpye { get; set; }
        public Struct40 _struct { get; set; }
    }

    public class Struct40
    {
        public Id30 id { get; set; }
        public Name4 name { get; set; }
        public Desc8 desc { get; set; }
        public Menulist4 menuList { get; set; }
        public Permissionlist4 permissionList { get; set; }
    }

    public class Id30
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist4
    {
        public string type { get; set; }
        public Struct41 _struct { get; set; }
    }

    public class Struct41
    {
        public Id31 id { get; set; }
        public Menuname5 menuName { get; set; }
        public Url5 url { get; set; }
        public Parentid10 parentId { get; set; }
    }

    public class Id31
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist4
    {
        public string type { get; set; }
        public Struct42 _struct { get; set; }
    }

    public class Struct42
    {
        public Id32 id { get; set; }
        public Permission5 permission { get; set; }
        public Desc9 desc { get; set; }
    }

    public class Id32
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstateenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodimageentitylist
    {
        public string type { get; set; }
        public Struct43 _struct { get; set; }
    }

    public class Struct43
    {
        public Id33 id { get; set; }
        public Imageurl1 imageURL { get; set; }
        public Productid1 productId { get; set; }
    }

    public class Id33
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imageurl1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity1
    {
        public string type { get; set; }
        public Struct44 _struct { get; set; }
    }

    public class Struct44
    {
        public Id34 id { get; set; }
        public Username9 username { get; set; }
        public Password9 password { get; set; }
        public Phone10 phone { get; set; }
        public Mail9 mail { get; set; }
        public Licencepic7 licencePic { get; set; }
        public Registertime5 registerTime { get; set; }
        public Usertypeenum4 userTypeEnum { get; set; }
        public Userstateenum4 userStateEnum { get; set; }
        public Roleentity4 roleEntity { get; set; }
    }

    public class Id34
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity4
    {
        public string type { get; set; }
        public Struct45 _struct { get; set; }
    }

    public class Struct45
    {
        public Id35 id { get; set; }
        public Name5 name { get; set; }
        public Desc10 desc { get; set; }
        public Menulist5 menuList { get; set; }
        public Permissionlist5 permissionList { get; set; }
    }

    public class Id35
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist5
    {
        public string type { get; set; }
        public Struct46 _struct { get; set; }
    }

    public class Struct46
    {
        public Id36 id { get; set; }
        public Menuname6 menuName { get; set; }
        public Url6 url { get; set; }
        public Parentid11 parentId { get; set; }
    }

    public class Id36
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist5
    {
        public string type { get; set; }
        public Struct47 _struct { get; set; }
    }

    public class Struct47
    {
        public Id37 id { get; set; }
        public Permission6 permission { get; set; }
        public Desc11 desc { get; set; }
    }

    public class Id37
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity5
    {
        public string type { get; set; }
        public Struct48 _struct { get; set; }
    }

    public class Struct48
    {
        public Id38 id { get; set; }
        public Name6 name { get; set; }
        public Desc12 desc { get; set; }
        public Menulist6 menuList { get; set; }
        public Permissionlist6 permissionList { get; set; }
    }

    public class Id38
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist6
    {
        public string type { get; set; }
        public Struct49 _struct { get; set; }
    }

    public class Struct49
    {
        public Id39 id { get; set; }
        public Menuname7 menuName { get; set; }
        public Url7 url { get; set; }
        public Parentid13 parentId { get; set; }
    }

    public class Id39
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist6
    {
        public string type { get; set; }
        public Struct50 _struct { get; set; }
    }

    public class Struct50
    {
        public Id40 id { get; set; }
        public Permission7 permission { get; set; }
        public Desc13 desc { get; set; }
    }

    public class Id40
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist7
    {
        public string type { get; set; }
        public Struct51 _struct { get; set; }
    }

    public class Struct51
    {
        public Id41 id { get; set; }
        public Menuname8 menuName { get; set; }
        public Url8 url { get; set; }
        public Parentid14 parentId { get; set; }
    }

    public class Id41
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist7
    {
        public string type { get; set; }
        public Struct52 _struct { get; set; }
    }

    public class Struct52
    {
        public Id42 id { get; set; }
        public Permission8 permission { get; set; }
        public Desc15 desc { get; set; }
    }

    public class Id42
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id43
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userentity2
    {
        public string type { get; set; }
        public Struct53 _struct { get; set; }
    }

    public class Struct53
    {
        public Id44 id { get; set; }
        public Username11 username { get; set; }
        public Password11 password { get; set; }
        public Phone12 phone { get; set; }
        public Mail11 mail { get; set; }
        public Licencepic9 licencePic { get; set; }
        public Registertime7 registerTime { get; set; }
        public Usertypeenum6 userTypeEnum { get; set; }
        public Userstateenum6 userStateEnum { get; set; }
        public Roleentity6 roleEntity { get; set; }
    }

    public class Id44
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum6
    {
        public string type { get; set; }
        public Struct54 _struct { get; set; }
    }

    public class Struct54
    {
        public Code4 code { get; set; }
        public Msg4 msg { get; set; }
    }

    public class Code4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum6
    {
        public string type { get; set; }
        public Struct55 _struct { get; set; }
    }

    public class Struct55
    {
        public Code5 code { get; set; }
        public Msg5 msg { get; set; }
    }

    public class Code5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity6
    {
        public string type { get; set; }
        public Struct56 _struct { get; set; }
    }

    public class Struct56
    {
        public Id45 id { get; set; }
        public Name8 name { get; set; }
        public Desc16 desc { get; set; }
        public Menulist8 menuList { get; set; }
        public Permissionlist8 permissionList { get; set; }
    }

    public class Id45
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist8
    {
        public string type { get; set; }
        public Struct57 _struct { get; set; }
    }

    public class Struct57
    {
        public Id46 id { get; set; }
        public Menuname10 menuName { get; set; }
        public Url10 url { get; set; }
        public Parentid16 parentId { get; set; }
    }

    public class Id46
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist8
    {
        public string type { get; set; }
        public Struct58 _struct { get; set; }
    }

    public class Struct58
    {
        public Id47 id { get; set; }
        public Permission10 permission { get; set; }
        public Desc17 desc { get; set; }
    }

    public class Id47
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Call
    {
        public string targetMicroservices { get; set; }
        public string interfaceName { get; set; }
        public string[] positions { get; set; }
    }

}
