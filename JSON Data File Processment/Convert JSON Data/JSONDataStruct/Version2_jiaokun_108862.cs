using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version2_jiaokun_108862
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
    }

    public class Version
    {
        public string sha { get; set; }
        public string tag { get; set; }
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
        public Keyword keyword { get; set; }
        public Currentpage1 currentPage1 { get; set; }
        public Currentpage2 currentPage2 { get; set; }
        public Uid uid { get; set; }
        public Registered registered { get; set; }
        public Updatebody updateBody { get; set; }
        public Adminuid adminUid { get; set; }
        public Newinfo newInfo { get; set; }
        public Validcode validCode { get; set; }
        public Adminuids adminUids { get; set; }
        public Userinfo userInfo { get; set; }
        public Password2 passWord { get; set; }
        public Newpassword newPassWord { get; set; }
        public Oldtoken oldToken { get; set; }
        public Blogvo BlogVO { get; set; }
        public Result result { get; set; }
        public Blogsortvo BlogSortVO { get; set; }
        public Menulevel menuLevel { get; set; }
        public Currentpage currentPage { get; set; }
        public Pagesize pageSize { get; set; }
        public Categorymenu categoryMenu { get; set; }
        public Comment comment { get; set; }
        public Linkvo linkVO { get; set; }
        public Username3 username { get; set; }
        public Password3 password { get; set; }
        public Isrememberme isRememberMe { get; set; }
        public Token token { get; set; }
        public Username4 userName { get; set; }
        public Operation operation { get; set; }
        public Starttime startTime { get; set; }
        public Picturesortuid pictureSortUid { get; set; }
        public Fileuids fileUids { get; set; }
        public Picname picName { get; set; }
        public string type { get; set; }
        public object name { get; set; }
        public Fileuid1 fileUid { get; set; }
        public Pictureuid pictureUid { get; set; }
        public Parentuid1 parentUid { get; set; }
        public Resourcesortvo resourceSortVO { get; set; }
        public Rolevo roleVO { get; set; }
        public Keywords keywords { get; set; }
        public Bolg Bolg { get; set; }
        public Studyvideovo studyVideoVO { get; set; }
        public Oldpwd oldPwd { get; set; }
        public Newpwd newPwd { get; set; }
        public Admin admin { get; set; }
        public Tagvo tagVO { get; set; }
        public Tagvolist tagVOList { get; set; }
        public Todovo todoVO { get; set; }
        public Uservo userVO { get; set; }
        public Webconfigvo webConfigVO { get; set; }
        public Webvisitvo webVisitVO { get; set; }
        public Source1 source { get; set; }
        public Callback callback { get; set; }
        public Accesstoken accessToken { get; set; }
        public Taguid1 tagUid { get; set; }
        public Bloguid1 blogUid { get; set; }
        public Blogsortuid1 blogSortUid { get; set; }
        public Level1 level { get; set; }
        public Pagename pageName { get; set; }
        public Resourcesortuid1 resourceSortUid { get; set; }
        public Author2 author { get; set; }
        public Monthdate monthDate { get; set; }
        public Urlstring urlString { get; set; }
        public I i { get; set; }
        public Fileids fileIds { get; set; }
        public Code1 code { get; set; }
        public Filedatas filedatas { get; set; }
        public Filevo fileVO { get; set; }
    }

    public class Keyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registered
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Serialversionuid serialVersionUID { get; set; }
        public Username userName { get; set; }
        public Roleuid roleUid { get; set; }
        public Password passWord { get; set; }
        public Nickname nickName { get; set; }
        public Gender gender { get; set; }
        public Avatar avatar { get; set; }
        public Email email { get; set; }
        public Birthday birthday { get; set; }
        public Mobile mobile { get; set; }
        public Qqnumber qqNumber { get; set; }
        public Wechat weChat { get; set; }
        public Occupation occupation { get; set; }
        public Summary summary { get; set; }
        public Logincount loginCount { get; set; }
    }

    public class Serialversionuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gender
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Birthday
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logincount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatebody
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
    }

    public class Struct1
    {
        public Serialversionuid1 serialVersionUID { get; set; }
        public Username1 userName { get; set; }
        public Roleuid1 roleUid { get; set; }
        public Password1 passWord { get; set; }
        public Nickname1 nickName { get; set; }
        public Gender1 gender { get; set; }
        public Avatar1 avatar { get; set; }
        public Email1 email { get; set; }
        public Birthday1 birthday { get; set; }
        public Mobile1 mobile { get; set; }
        public Qqnumber1 qqNumber { get; set; }
        public Wechat1 weChat { get; set; }
        public Occupation1 occupation { get; set; }
        public Summary1 summary { get; set; }
        public Logincount1 loginCount { get; set; }
    }

    public class Serialversionuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gender1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Birthday1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logincount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Newinfo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userinfo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Newpassword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oldtoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogvo
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
    }

    public class Struct2
    {
        public Title title { get; set; }
        public Summary2 summary { get; set; }
        public Content content { get; set; }
        public Taguid tagUid { get; set; }
        public Blogsortuid blogSortUid { get; set; }
        public Fileuid fileUid { get; set; }
        public Adminuid1 adminUid { get; set; }
        public Ispublish isPublish { get; set; }
        public Isoriginal isOriginal { get; set; }
        public Author author { get; set; }
        public Articlespart articlesPart { get; set; }
        public Level level { get; set; }
        public Taglist tagList { get; set; }
        public Photolist photoList { get; set; }
        public Blogsort blogSort { get; set; }
        public Praisecount praiseCount { get; set; }
        public Copyright copyright { get; set; }
        public Levelkeyword levelKeyword { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isoriginal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articlespart
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taglist
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public Content1 content { get; set; }
        public Clickcount clickCount { get; set; }
        public Sort sort { get; set; }
        public Serialversionuid2 serialVersionUID { get; set; }
        public Uid1 uid { get; set; }
        public Status status { get; set; }
        public Createtime createTime { get; set; }
        public Updatetime updateTime { get; set; }
    }

    public class Content1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Serialversionuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsort
    {
        public string type { get; set; }
        public Struct4 _struct { get; set; }
    }

    public class Struct4
    {
        public Serialversionuid3 serialVersionUID { get; set; }
        public Sortname sortName { get; set; }
        public Content2 content { get; set; }
        public Clickcount1 clickCount { get; set; }
        public Sort1 sort { get; set; }
    }

    public class Serialversionuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Praisecount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Copyright
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Levelkeyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortvo
    {
        public string type { get; set; }
        public Struct5 _struct { get; set; }
    }

    public class Struct5
    {
        public Sortname1 sortName { get; set; }
        public Content3 content { get; set; }
    }

    public class Sortname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulevel
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categorymenu
    {
        public string type { get; set; }
        public Struct6 _struct { get; set; }
    }

    public class Struct6
    {
        public Serialversionuid4 serialVersionUID { get; set; }
        public Name name { get; set; }
        public Menulevel1 menuLevel { get; set; }
        public Summary3 summary { get; set; }
        public Icon icon { get; set; }
        public Parentuid parentUid { get; set; }
        public Url url { get; set; }
        public Namsorte namsorte { get; set; }
        public Parentcategorymenu parentCategoryMenu { get; set; }
        public Childcategorymenu childCategoryMenu { get; set; }
    }

    public class Serialversionuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulevel1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Icon
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Namsorte
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentcategorymenu
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Childcategorymenu
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Comment
    {
        public string type { get; set; }
        public Struct7 _struct { get; set; }
    }

    public class Struct7
    {
        public Serialversionuid5 serialVersionUID { get; set; }
        public Useruid userUid { get; set; }
        public Touid toUid { get; set; }
        public Touseruid toUserUid { get; set; }
        public Username2 userName { get; set; }
        public Content4 content { get; set; }
        public Bloguid blogUid { get; set; }
    }

    public class Serialversionuid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useruid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Touid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Touseruid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bloguid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Linkvo
    {
        public string type { get; set; }
        public Struct8 _struct { get; set; }
    }

    public class Struct8
    {
        public Title1 title { get; set; }
        public Summary4 summary { get; set; }
        public Url1 url { get; set; }
    }

    public class Title1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url1
    {
        public string type { get; set; }
        public string name { get; set; }
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

    public class Isrememberme
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Token
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Operation
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picturesortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pictureuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortvo
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Uid2 uid { get; set; }
        public Content5 content { get; set; }
        public Currentpage3 currentPage { get; set; }
        public Fileuid2 fileUid { get; set; }
        public Keyword1 keyword { get; set; }
        public Pagesize1 pageSize { get; set; }
        public Sortname2 sortName { get; set; }
        public Status1 status { get; set; }
    }

    public class Uid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolevo
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public Categorymenuuids categoryMenuUids { get; set; }
        public Currentpage4 currentPage { get; set; }
        public Keyword2 keyword { get; set; }
        public Pagesize2 pageSize { get; set; }
        public Rolename roleName { get; set; }
        public Status2 status { get; set; }
        public Summary5 summary { get; set; }
        public Uid3 uid { get; set; }
    }

    public class Categorymenuuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keywords
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bolg
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Studyvideovo
    {
        public string type { get; set; }
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public Baidupath baiduPath { get; set; }
        public Content6 content { get; set; }
        public Currentpage5 currentPage { get; set; }
        public Fileuid3 fileUid { get; set; }
        public Keyword3 keyword { get; set; }
        public Name1 name { get; set; }
        public Pagesize3 pageSize { get; set; }
        public Resourcesortuid resourceSortUid { get; set; }
        public Status3 status { get; set; }
        public Summary6 summary { get; set; }
        public Uid4 uid { get; set; }
    }

    public class Baidupath
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oldpwd
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Newpwd
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Admin
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
    {
        public Username5 userName { get; set; }
        public Roleuid2 roleUid { get; set; }
        public Password4 passWord { get; set; }
        public Nickname2 nickName { get; set; }
        public Gender2 gender { get; set; }
        public Avatar2 avatar { get; set; }
        public Email2 email { get; set; }
        public Birthday2 birthday { get; set; }
        public Mobile2 mobile { get; set; }
        public Qqnumber2 qqNumber { get; set; }
        public Wechat2 weChat { get; set; }
        public Occupation2 occupation { get; set; }
        public Summary7 summary { get; set; }
        public Personresume personResume { get; set; }
        public Logincount2 loginCount { get; set; }
        public Lastlogintime lastLoginTime { get; set; }
        public Lastloginip lastLoginIp { get; set; }
        public Github github { get; set; }
        public Gitee gitee { get; set; }
        public Photolist1 photoList { get; set; }
        public Rolenames roleNames { get; set; }
        public Validcode1 validCode { get; set; }
        public Role role { get; set; }
    }

    public class Username5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gender2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Birthday2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Personresume
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logincount2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Lastlogintime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Lastloginip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Github
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gitee
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist1
    {
        public string type { get; set; }
        public Struct13 _struct { get; set; }
    }

    public class Struct13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolenames
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validcode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Role
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
    }

    public class Struct15
    {
        public Rolename1 roleName { get; set; }
        public Summary8 summary { get; set; }
        public Categorymenuuids1 categoryMenuUids { get; set; }
    }

    public class Rolename1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categorymenuuids1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tagvo
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Content7 content { get; set; }
        public Currentpage6 currentPage { get; set; }
        public Keyword4 keyword { get; set; }
        public Pagesize4 pageSize { get; set; }
        public Sort2 sort { get; set; }
        public Uid5 uid { get; set; }
    }

    public class Content7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tagvolist
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Tagvo1 tagVO { get; set; }
    }

    public class Tagvo1
    {
        public string type { get; set; }
        public Struct18 _struct { get; set; }
    }

    public class Struct18
    {
        public Content8 content { get; set; }
        public Currentpage7 currentPage { get; set; }
        public Keyword5 keyword { get; set; }
        public Pagesize5 pageSize { get; set; }
        public Sort3 sort { get; set; }
        public Uid6 uid { get; set; }
    }

    public class Content8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Todovo
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Currentpage8 currentPage { get; set; }
        public Keyword6 keyword { get; set; }
        public Pagesize6 pageSize { get; set; }
        public Done done { get; set; }
        public Status4 status { get; set; }
        public Text text { get; set; }
        public Uid7 uid { get; set; }
    }

    public class Currentpage8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Done
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Text
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uservo
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Avatar3 avatar { get; set; }
        public Birthday3 birthday { get; set; }
        public Currentpage9 currentPage { get; set; }
        public Email3 email { get; set; }
        public Gender3 gender { get; set; }
        public Keyword7 keyword { get; set; }
        public Mobile3 mobile { get; set; }
        public Nickname3 nickName { get; set; }
        public Occupation3 occupation { get; set; }
        public Pagesize7 pageSize { get; set; }
        public Password5 passWord { get; set; }
        public Qqnumber3 qqNumber { get; set; }
        public Source source { get; set; }
        public Status5 status { get; set; }
        public Summary9 summary { get; set; }
        public Uid8 uid { get; set; }
        public Username6 userName { get; set; }
        public Uuid uuid { get; set; }
        public Wechat3 weChat { get; set; }
    }

    public class Avatar3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Birthday3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gender3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Source
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Webconfigvo
    {
        public string type { get; set; }
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Alipay aliPay { get; set; }
        public Alipayphoto aliPayPhoto { get; set; }
        public Author1 author { get; set; }
        public Email4 email { get; set; }
        public Currentpage10 currentPage { get; set; }
        public Gitee1 gitee { get; set; }
        public Github1 github { get; set; }
        public Keyword8 keyword { get; set; }
        public Logo logo { get; set; }
        public Qqgroup qqGroup { get; set; }
        public Pagesize8 pageSize { get; set; }
        public Qqnumber4 qqNumber { get; set; }
        public Recordnum recordNum { get; set; }
        public Showlist showList { get; set; }
        public Startcomment startComment { get; set; }
        public Status6 status { get; set; }
        public Summary10 summary { get; set; }
        public Title2 title { get; set; }
        public Uid9 uid { get; set; }
        public Wechat4 weChat { get; set; }
        public Weixinpay weixinPay { get; set; }
        public Weixinpayphoto weixinPayPhoto { get; set; }
        public Photolist2 photoList { get; set; }
    }

    public class Alipay
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Alipayphoto
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gitee1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Github1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqgroup
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recordnum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Showlist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Startcomment
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weixinpay
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weixinpayphoto
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist2
    {
        public string type { get; set; }
        public Struct22 _struct { get; set; }
    }

    public class Struct22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Webvisitvo
    {
        public string type { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Behavior behavior { get; set; }
        public Behaviorcontent behaviorContent { get; set; }
        public Browser browser { get; set; }
        public Content9 content { get; set; }
        public Currentpage11 currentPage { get; set; }
        public Ip ip { get; set; }
        public Keyword9 keyword { get; set; }
        public Moduleuid moduleUid { get; set; }
        public Os os { get; set; }
        public Otherdata otherData { get; set; }
        public Pagesize9 pageSize { get; set; }
        public Starttime1 startTime { get; set; }
        public Status7 status { get; set; }
        public Uid10 uid { get; set; }
        public Useruid1 userUid { get; set; }
    }

    public class Behavior
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Behaviorcontent
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Browser
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Moduleuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Os
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Otherdata
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useruid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Source1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Callback
    {
        public string type { get; set; }
        public Struct24 _struct { get; set; }
    }

    public class Struct24
    {
        public Code code { get; set; }
        public Auth_Code auth_code { get; set; }
        public State state { get; set; }
        public Authorization_Code authorization_code { get; set; }
        public Oauthtoken oauthToken { get; set; }
        public Oauthverifier oauthVerifier { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Auth_Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class State
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Authorization_Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oauthtoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oauthverifier
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bloguid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Monthdate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Urlstring
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class I
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Code1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Filedatas
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Filevo
    {
        public Struct25 _struct { get; set; }
    }

    public class Struct25
    {
        public Useruid2 userUid { get; set; }
        public Adminuid2 adminUid { get; set; }
        public Projectname projectName { get; set; }
        public Sortname3 sortName { get; set; }
        public Urllist urlList { get; set; }
    }

    public class Useruid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Projectname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Urllist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Call
    {
        public string targetMicroservices { get; set; }
        public string interfaceName { get; set; }
        public string[] position { get; set; }
        public string[] positions { get; set; }
    }

}
