using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version1_guxueshan_108875
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
        public Pictureuid pictureUid { get; set; }
        public Name1 name { get; set; }
        public Parentuid1 parentUid { get; set; }
        public Fileuid1 fileUid { get; set; }
        public Sortname2 sortName { get; set; }
        public Content5 content { get; set; }
        public Rolevo roleVO { get; set; }
        public Keywords keywords { get; set; }
        public Blog blog { get; set; }
        public Studyvideo studyVideo { get; set; }
        public Admin admin { get; set; }
        public Oldpwd oldPwd { get; set; }
        public Newpwd newPwd { get; set; }
        public Tagvo tagVO { get; set; }
        public Todovo todoVO { get; set; }
        public Uservo userVO { get; set; }
        public Webconfigvo webConfigVO { get; set; }
        public Webvisitvo webVisitVO { get; set; }
        public Request request { get; set; }
        public Response response { get; set; }
        public Urlstring urlString { get; set; }
        public I i { get; set; }
        public Fileids fileIds { get; set; }
        public Code code { get; set; }
        public Filedatas filedatas { get; set; }
        public Useruid2 userUid { get; set; }
        public Projectname projectName { get; set; }
        public Urllist urlList { get; set; }
        public Source1 source { get; set; }
        public Accesstoken accessToken { get; set; }
        public Taguid2 tagUid { get; set; }
        public Bloguid1 blogUid { get; set; }
        public Level2 level { get; set; }
        public Pagename pageName { get; set; }
        public Resourcesortuid1 resourceSortUid { get; set; }
        public Blogsortuid2 blogSortUid { get; set; }
        public Author3 author { get; set; }
        public Monthdate monthDate { get; set; }
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

    public class Pictureuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolevo
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Rolename roleName { get; set; }
        public Summary5 summary { get; set; }
        public Categorymenuuids categoryMenuUids { get; set; }
    }

    public class Rolename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categorymenuuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keywords
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blog
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public Serialversionuid6 serialVersionUID { get; set; }
        public Title2 title { get; set; }
        public Summary6 summary { get; set; }
        public Content6 content { get; set; }
        public Taguid1 tagUid { get; set; }
        public Blogsortuid1 blogSortUid { get; set; }
        public Clickcount2 clickCount { get; set; }
        public Collectcount collectCount { get; set; }
        public Fileuid2 fileUid { get; set; }
        public Adminuid2 adminUid { get; set; }
        public Ispublish1 isPublish { get; set; }
        public Isoriginal1 isOriginal { get; set; }
        public Author1 author { get; set; }
        public Articlespart1 articlesPart { get; set; }
        public Level1 level { get; set; }
        public Taglist1 tagList { get; set; }
        public Photolist1 photoList { get; set; }
        public Blogsort1 blogSort { get; set; }
        public Praisecount1 praiseCount { get; set; }
        public Copyright1 copyright { get; set; }
    }

    public class Serialversionuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Collectcount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isoriginal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articlespart1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taglist1
    {
        public string type { get; set; }
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public Serialversionuid7 serialVersionUID { get; set; }
        public Content7 content { get; set; }
        public Clickcount3 clickCount { get; set; }
        public Sort2 sort { get; set; }
    }

    public class Serialversionuid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsort1
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
    {
        public Serialversionuid8 serialVersionUID { get; set; }
        public Sortname3 sortName { get; set; }
        public Content8 content { get; set; }
        public Clickcount4 clickCount { get; set; }
        public Sort3 sort { get; set; }
    }

    public class Serialversionuid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Praisecount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Copyright1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Studyvideo
    {
        public string type { get; set; }
        public Struct13 _struct { get; set; }
    }

    public class Struct13
    {
        public Serialversionuid9 serialVersionUID { get; set; }
        public Name2 name { get; set; }
        public Summary7 summary { get; set; }
        public Content9 content { get; set; }
        public Baidupath baiduPath { get; set; }
        public Fileuid3 fileUid { get; set; }
        public Resourcesortuid resourceSortUid { get; set; }
        public Clickcount5 clickCount { get; set; }
        public Photolist2 photoList { get; set; }
        public Resourcesort resourceSort { get; set; }
    }

    public class Serialversionuid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Baidupath
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesort
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public Serialversionuid10 serialVersionUID { get; set; }
        public Sortname4 sortName { get; set; }
        public Content10 content { get; set; }
        public Fileuid4 fileUid { get; set; }
        public Clickcount6 clickCount { get; set; }
        public Sort4 sort { get; set; }
        public Photolist3 photoList { get; set; }
    }

    public class Serialversionuid10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Admin
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
    }

    public class Struct15
    {
        public Serialversionuid11 serialVersionUID { get; set; }
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
        public Summary8 summary { get; set; }
        public Logincount2 loginCount { get; set; }
        public Lastlogintime lastLoginTime { get; set; }
        public Lastloginip lastLoginIp { get; set; }
        public Github github { get; set; }
        public Gitee gitee { get; set; }
        public Photolist4 photoList { get; set; }
        public Rolenames roleNames { get; set; }
        public Role role { get; set; }
        public Validcode1 validCode { get; set; }
    }

    public class Serialversionuid11
    {
        public string type { get; set; }
        public string name { get; set; }
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

    public class Summary8
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

    public class Photolist4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolenames
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Role
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Serialversionuid12 serialVersionUID { get; set; }
        public Rolename1 roleName { get; set; }
        public Summary9 summary { get; set; }
        public Categorymenuuids1 categoryMenuUids { get; set; }
    }

    public class Serialversionuid12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolename1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categorymenuuids1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validcode1
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

    public class Tagvo
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Content11 content { get; set; }
        public Uid2 uid { get; set; }
        public Status1 status1 { get; set; }
        public Keyword1 keyword { get; set; }
        public Currentpage3 currentPage { get; set; }
        public Status2 status2 { get; set; }
    }

    public class Content11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Todovo
    {
        public string type { get; set; }
        public Struct18 _struct { get; set; }
    }

    public class Struct18
    {
        public Text text { get; set; }
        public Done done { get; set; }
    }

    public class Text
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Done
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uservo
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Username6 userName { get; set; }
        public Password5 passWord { get; set; }
        public Nickname3 nickName { get; set; }
        public Gender3 gender { get; set; }
        public Avatar3 avatar { get; set; }
        public Email3 email { get; set; }
        public Birthday3 birthday { get; set; }
        public Mobile3 mobile { get; set; }
        public Qqnumber3 qqNumber { get; set; }
        public Wechat3 weChat { get; set; }
        public Occupation3 occupation { get; set; }
        public Summary10 summary { get; set; }
        public Source source { get; set; }
        public Uuid uuid { get; set; }
    }

    public class Username6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gender3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Birthday3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Source
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Webconfigvo
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Logo logo { get; set; }
        public Name3 name { get; set; }
        public Title3 title { get; set; }
        public Summary11 summary { get; set; }
        public Keyword2 keyword { get; set; }
        public Author2 author { get; set; }
        public Recordnum recordNum { get; set; }
        public Alipay aliPay { get; set; }
        public Weixinpay weixinPay { get; set; }
        public Startcomment startComment { get; set; }
        public Photolist5 photoList { get; set; }
        public Alipayphoto aliPayPhoto { get; set; }
        public Weixinpayphoto weixinPayPhoto { get; set; }
        public Uid3 uid { get; set; }
        public Status3 status { get; set; }
    }

    public class Logo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recordnum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Alipay
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weixinpay
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Startcomment
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Alipayphoto
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weixinpayphoto
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Webvisitvo
    {
        public string type { get; set; }
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Useruid1 userUid { get; set; }
        public Ip ip { get; set; }
        public Os os { get; set; }
        public Browser browser { get; set; }
        public Behavior behavior { get; set; }
        public Moduleuid moduleUid { get; set; }
        public Otherdata otherData { get; set; }
        public Starttime1 startTime { get; set; }
        public Content12 content { get; set; }
        public Behaviorcontent behaviorContent { get; set; }
        public Uid4 uid { get; set; }
        public Status4 status { get; set; }
    }

    public class Useruid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Os
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Browser
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Behavior
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Moduleuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Otherdata
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Behaviorcontent
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Request
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Response
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

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Filedatas
    {
        public string type { get; set; }
    }

    public class Useruid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Projectname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Urllist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Source1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bloguid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level2
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

    public class Blogsortuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Monthdate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public string type { get; set; }
        public string name { get; set; }
        public Hello hello { get; set; }
        public Child _ { get; set; }
        public Struct22 _struct { get; set; }
        public List1 List { get; set; }
        public Set Set { get; set; }
    }

    public class Hello
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Child
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Struct22
    {
        public Nickname4 nickName { get; set; }
        public Occupation4 occupation { get; set; }
        public Summary12 summary { get; set; }
        public Wechat4 weChat { get; set; }
        public Qqnumber4 qqNumber { get; set; }
        public Email4 email { get; set; }
        public Mobile4 mobile { get; set; }
        public Avatar4 avatar { get; set; }
        public Photolist6 photoList { get; set; }
        public Github1 github { get; set; }
        public Gitee1 gitee { get; set; }
        public Title4 title { get; set; }
        public Content13 content { get; set; }
        public Taguid3 tagUid { get; set; }
        public Blogsortuid3 blogSortUid { get; set; }
        public Clickcount7 clickCount { get; set; }
        public Collectcount1 collectCount { get; set; }
        public Fileuid5 fileUid { get; set; }
        public Adminuid3 adminUid { get; set; }
        public Ispublish2 isPublish { get; set; }
        public Isoriginal2 isOriginal { get; set; }
        public Author4 author { get; set; }
        public Articlespart2 articlesPart { get; set; }
        public Level3 level { get; set; }
        public Taglist2 tagList { get; set; }
        public Blogsort2 blogSort { get; set; }
        public Praisecount2 praiseCount { get; set; }
        public Copyright2 copyright { get; set; }
        public Logo1 logo { get; set; }
        public Name4 name { get; set; }
        public Keyword3 keyword { get; set; }
        public Recordnum1 recordNum { get; set; }
        public Alipay1 aliPay { get; set; }
        public Weixinpay1 weixinPay { get; set; }
        public Startcomment1 startComment { get; set; }
        public Alipayphoto1 aliPayPhoto { get; set; }
        public Weixinpayphoto1 weixinPayPhoto { get; set; }
    }

    public class Nickname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist6
    {
        public string type { get; set; }
        public string name { get; set; }
        public List List { get; set; }
    }

    public class List
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Github1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gitee1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Collectcount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isoriginal2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articlespart2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taglist2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Praisecount2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Copyright2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logo1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recordnum1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Alipay1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weixinpay1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Startcomment1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Alipayphoto1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weixinpayphoto1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class List1
    {
        public string type { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Title5 title { get; set; }
        public Summary13 summary { get; set; }
        public Content14 content { get; set; }
        public Taguid4 tagUid { get; set; }
        public Blogsortuid4 blogSortUid { get; set; }
        public Clickcount8 clickCount { get; set; }
        public Collectcount2 collectCount { get; set; }
        public Fileuid6 fileUid { get; set; }
        public Adminuid4 adminUid { get; set; }
        public Ispublish3 isPublish { get; set; }
        public Isoriginal3 isOriginal { get; set; }
        public Author5 author { get; set; }
        public Articlespart3 articlesPart { get; set; }
        public Level4 level { get; set; }
        public Taglist3 tagList { get; set; }
        public Photolist7 photoList { get; set; }
        public Blogsort3 blogSort { get; set; }
        public Praisecount3 praiseCount { get; set; }
        public Copyright3 copyright { get; set; }
        public Sort5 sort { get; set; }
        public Url2 url { get; set; }
        public Name5 name { get; set; }
        public Baidupath1 baiduPath { get; set; }
        public Resourcesortuid2 resourceSortUid { get; set; }
        public Resourcesort1 resourceSort { get; set; }
        public Sortname6 sortName { get; set; }
    }

    public class Title5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Collectcount2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isoriginal3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articlespart3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taglist3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist7
    {
        public string type { get; set; }
        public string name { get; set; }
        public List2 List { get; set; }
    }

    public class List2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Praisecount3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Copyright3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Baidupath1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesort1
    {
        public string type { get; set; }
        public Struct24 _struct { get; set; }
    }

    public class Struct24
    {
        public Sortname5 sortName { get; set; }
        public Content15 content { get; set; }
        public Clickcount9 clickCount { get; set; }
        public Fileuid7 fileUid { get; set; }
        public Sort6 sort { get; set; }
        public Photolist8 photoList { get; set; }
    }

    public class Sortname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist8
    {
        public string type { get; set; }
        public List3 List { get; set; }
    }

    public class List3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Set
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
