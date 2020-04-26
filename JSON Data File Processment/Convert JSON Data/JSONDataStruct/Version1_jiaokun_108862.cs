using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version1_jiaokun_108862
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
        public Uid uid { get; set; }
        public Taguid tagUid { get; set; }
        public Currentpage currentPage { get; set; }
        public Pagesize pageSize { get; set; }
        public Bloguid blogUid { get; set; }
        public Blogsortuid blogSortUid { get; set; }
        public Level level { get; set; }
        public Pagename pageName { get; set; }
        public Callback callback { get; set; }
        public User_Id user_id { get; set; }
        public Nickname nickname { get; set; }
        public Sign sign { get; set; }
        public Img_Url img_url { get; set; }
        public Profile_Url profile_url { get; set; }
        public Username userName { get; set; }
        public Email email { get; set; }
        public Password passWord { get; set; }
        public Code code { get; set; }
        public Resourcesortuid resourceSortUid { get; set; }
        public Keywords keywords { get; set; }
        public Author author { get; set; }
        public Monthdate monthDate { get; set; }
        public Admin admin { get; set; }
        public string type { get; set; }
        public object name { get; set; }
        public Adminuids adminUids { get; set; }
        public Keyword keyword { get; set; }
        public Newinfo newInfo { get; set; }
        public Validcode1 validCode { get; set; }
        public Blogvo blogVO { get; set; }
        public Blogvolist blogVoList { get; set; }
        public Blogsortvo blogSortVO { get; set; }
        public Blogsortvolist blogSortVOList { get; set; }
        public Userinfo userInfo { get; set; }
        public Newpassword newPassWord { get; set; }
        public Username2 username { get; set; }
        public Password2 password { get; set; }
        public Isrememberme isRememberMe { get; set; }
        public Categorymenuvo categoryMenuVO { get; set; }
        public Commentvo commentVO { get; set; }
        public Commentvolist commentVOList { get; set; }
        public Linkvo linkVO { get; set; }
        public Todovo todoVO { get; set; }
        public Fileuids fileUids { get; set; }
        public Picturesortuid pictureSortUid { get; set; }
        public Fileuid2 fileUid { get; set; }
        public Picname picName { get; set; }
        public Pictureuid pictureUid { get; set; }
        public Parentuid1 parentUid { get; set; }
        public Resourcesortvo resourceSortVO { get; set; }
        public Resourcesortvolist resourceSortVOList { get; set; }
        public Rolevo roleVO { get; set; }
        public Studyvideovo studyVideoVO { get; set; }
        public Studyvideovolist studyVideoVOList { get; set; }
        public Operation operation { get; set; }
        public Starttime startTime { get; set; }
        public Uservo userVO { get; set; }
        public Tagvo tagVO { get; set; }
        public Tagvolist tagVOList { get; set; }
        public Sysdictdatavo sysDictDataVO { get; set; }
        public Sysdictdatavolist sysDictDataVOList { get; set; }
        public Dicttypelist dictTypeList { get; set; }
        public Oldpwd oldPwd { get; set; }
        public Newpwd newPwd { get; set; }
        public Webvisitvo webVisitVO { get; set; }
        public Webconfigvo webConfigVO { get; set; }
        public Systemconfigvo systemConfigVO { get; set; }
        public Sysdicttypevo sysDictTypeVO { get; set; }
        public Sysdicttypevolist sysDictTypeVOList { get; set; }
        public Urlstring urlString { get; set; }
        public I i { get; set; }
        public File file { get; set; }
        public Fileids1 fileIds1 { get; set; }
        public Fileids2 fileIds2 { get; set; }
        public Filedatas filedatas { get; set; }
        public Filevo fileVO { get; set; }
        public Result result { get; set; }
        public Files files { get; set; }
    }

    public class Uid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid
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

    public class Bloguid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Callback
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class User_Id
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sign
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Img_Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Profile_Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keywords
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Monthdate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Admin
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Username1 userName { get; set; }
        public Roleuid roleUid { get; set; }
        public Password1 passWord { get; set; }
        public Nickname1 nickName { get; set; }
        public Gender gender { get; set; }
        public Avatar avatar { get; set; }
        public Email1 email { get; set; }
        public Birthday birthday { get; set; }
        public Mobile mobile { get; set; }
        public Qqnumber qqNumber { get; set; }
        public Wechat weChat { get; set; }
        public Occupation occupation { get; set; }
        public Summary summary { get; set; }
        public Personresume personResume { get; set; }
        public Logincount loginCount { get; set; }
        public Lastlogintime lastLoginTime { get; set; }
        public Lastloginip lastLoginIp { get; set; }
        public Github github { get; set; }
        public Gitee gitee { get; set; }
        public Photolist photoList { get; set; }
        public Rolenames roleNames { get; set; }
        public Validcode validCode { get; set; }
        public Role role { get; set; }
    }

    public class Username1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleuid
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

    public class Email1
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

    public class Personresume
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logincount
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

    public class Photolist
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
    }

    public class Struct1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolenames
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
    }

    public class Struct2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Role
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public Rolename roleName { get; set; }
        public Summary1 summary { get; set; }
        public Categorymenuuids categoryMenuUids { get; set; }
    }

    public class Rolename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categorymenuuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminuids
    {
        public string type { get; set; }
        public Struct4 _struct { get; set; }
    }

    public class Struct4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Newinfo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validcode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogvo
    {
        public string type { get; set; }
        public Struct5 _struct { get; set; }
    }

    public class Struct5
    {
        public Adminuid adminUid { get; set; }
        public Articlespart articlesPart { get; set; }
        public Author1 author { get; set; }
        public Blogsortuid1 blogSortUid { get; set; }
        public Copyright copyright { get; set; }
        public Fileuid fileUid { get; set; }
        public Isoriginal isOriginal { get; set; }
        public Ispublish isPublish { get; set; }
        public Keyword1 keyword { get; set; }
        public Levelkeyword levelKeyword { get; set; }
        public Level1 level { get; set; }
        public Currentpage1 currentPage { get; set; }
        public Pagesize1 pageSize { get; set; }
        public Praisecount praiseCount { get; set; }
        public Sort sort { get; set; }
        public Status status { get; set; }
        public Usesort useSort { get; set; }
        public Summary2 summary { get; set; }
        public Taguid1 tagUid { get; set; }
        public Title title { get; set; }
        public Uid1 uid { get; set; }
        public Blogsort blogSort { get; set; }
        public Photolist1 photoList { get; set; }
    }

    public class Adminuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articlespart
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Copyright
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isoriginal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Levelkeyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Praisecount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usesort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsort
    {
        public string type { get; set; }
        public Struct6 _struct { get; set; }
    }

    public class Struct6
    {
        public Ucontentid ucontentid { get; set; }
        public Createtime createTime { get; set; }
        public Sortname sortName { get; set; }
        public Uid2 uid { get; set; }
        public Updatetime updateTime { get; set; }
        public Clickcount clickCount { get; set; }
        public Sort1 sort { get; set; }
        public Status1 status { get; set; }
    }

    public class Ucontentid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist1
    {
        public string type { get; set; }
        public Struct7 _struct { get; set; }
    }

    public class Struct7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogvolist
    {
        public string type { get; set; }
        public Struct8 _struct { get; set; }
    }

    public class Struct8
    {
        public Blogvo1 blogVO { get; set; }
    }

    public class Blogvo1
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Adminuid1 adminUid { get; set; }
        public Articlespart1 articlesPart { get; set; }
        public Author2 author { get; set; }
        public Blogsortuid2 blogSortUid { get; set; }
        public Copyright1 copyright { get; set; }
        public Fileuid1 fileUid { get; set; }
        public Isoriginal1 isOriginal { get; set; }
        public Ispublish1 isPublish { get; set; }
        public Keyword2 keyword { get; set; }
        public Levelkeyword1 levelKeyword { get; set; }
        public Level2 level { get; set; }
        public Currentpage2 currentPage { get; set; }
        public Pagesize2 pageSize { get; set; }
        public Praisecount1 praiseCount { get; set; }
        public Sort2 sort { get; set; }
        public Status2 status { get; set; }
        public Usesort1 useSort { get; set; }
        public Summary3 summary { get; set; }
        public Taguid2 tagUid { get; set; }
        public Title1 title { get; set; }
        public Uid3 uid { get; set; }
        public Blogsort1 blogSort { get; set; }
        public Photolist2 photoList { get; set; }
    }

    public class Adminuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Articlespart1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Author2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Copyright1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isoriginal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Levelkeyword1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Level2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Praisecount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usesort1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taguid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsort1
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public Ucontentid1 ucontentid { get; set; }
        public Createtime1 createTime { get; set; }
        public Sortname1 sortName { get; set; }
        public Uid4 uid { get; set; }
        public Updatetime1 updateTime { get; set; }
        public Clickcount1 clickCount { get; set; }
        public Sort3 sort { get; set; }
        public Status3 status { get; set; }
    }

    public class Ucontentid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatetime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Clickcount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Photolist2
    {
        public string type { get; set; }
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortvo
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
    {
        public Content content { get; set; }
        public Currentpage3 currentPage { get; set; }
        public Keyword3 keyword { get; set; }
        public Pagesize3 pageSize { get; set; }
        public Sort4 sort { get; set; }
        public Sortname2 sortName { get; set; }
        public Status4 status { get; set; }
        public Uid5 uid { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Blogsortvolist
    {
        public string type { get; set; }
        public Struct13 _struct { get; set; }
    }

    public class Struct13
    {
        public Blogsortvo1 blogSortVO { get; set; }
    }

    public class Blogsortvo1
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public Content1 content { get; set; }
        public Currentpage4 currentPage { get; set; }
        public Keyword4 keyword { get; set; }
        public Pagesize4 pageSize { get; set; }
        public Sort5 sort { get; set; }
        public Sortname3 sortName { get; set; }
        public Status5 status { get; set; }
        public Uid6 uid { get; set; }
    }

    public class Content1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage4
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

    public class Sort5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userinfo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Newpassword
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

    public class Isrememberme
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categorymenuvo
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
    }

    public class Struct15
    {
        public Currentpage5 currentPage { get; set; }
        public Icon icon { get; set; }
        public Isshow isShow { get; set; }
        public Keyword5 keyword { get; set; }
        public Menulevel menuLevel { get; set; }
        public Name name { get; set; }
        public Pagesize5 pageSize { get; set; }
        public Parentuid parentUid { get; set; }
        public Sort6 sort { get; set; }
        public Status6 status { get; set; }
        public Summary4 summary { get; set; }
        public Uid7 uid { get; set; }
        public Url url { get; set; }
    }

    public class Currentpage5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Icon
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isshow
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulevel
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Commentvo
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Bloguid1 blogUid { get; set; }
        public Content2 content { get; set; }
        public Currentpage6 currentPage { get; set; }
        public Keyword6 keyword { get; set; }
        public Pagesize6 pageSize { get; set; }
        public Source source { get; set; }
        public Status7 status { get; set; }
        public Touid toUid { get; set; }
        public Touseruid toUserUid { get; set; }
        public Uid8 uid { get; set; }
        public Username3 userName { get; set; }
        public Useruid userUid { get; set; }
    }

    public class Bloguid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage6
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

    public class Source
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status7
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

    public class Uid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useruid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Commentvolist
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Commentvo1 commentVO { get; set; }
    }

    public class Commentvo1
    {
        public string type { get; set; }
        public Struct18 _struct { get; set; }
    }

    public class Struct18
    {
        public Bloguid2 blogUid { get; set; }
        public Content3 content { get; set; }
        public Currentpage7 currentPage { get; set; }
        public Keyword7 keyword { get; set; }
        public Pagesize7 pageSize { get; set; }
        public Source1 source { get; set; }
        public Status8 status { get; set; }
        public Touid1 toUid { get; set; }
        public Touseruid1 toUserUid { get; set; }
        public Uid9 uid { get; set; }
        public Username4 userName { get; set; }
        public Useruid1 userUid { get; set; }
    }

    public class Bloguid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Source1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Touid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Touseruid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useruid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Linkvo
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Currentpage8 currentPage { get; set; }
        public Keyword8 keyword { get; set; }
        public Pagesize8 pageSize { get; set; }
        public Sort7 sort { get; set; }
        public Status9 status { get; set; }
        public Summary5 summary { get; set; }
        public Title2 title { get; set; }
        public Uid10 uid { get; set; }
        public Url1 url { get; set; }
    }

    public class Currentpage8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Todovo
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Currentpage9 currentPage { get; set; }
        public Keyword9 keyword { get; set; }
        public Pagesize9 pageSize { get; set; }
        public Done done { get; set; }
        public Status10 status { get; set; }
        public Text text { get; set; }
        public Uid11 uid { get; set; }
    }

    public class Currentpage9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Done
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Text
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picturesortuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid2
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

    public class Parentuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortvo
    {
        public string type { get; set; }
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Uid12 uid { get; set; }
        public Content4 content { get; set; }
        public Currentpage10 currentPage { get; set; }
        public Fileuid3 fileUid { get; set; }
        public Keyword10 keyword { get; set; }
        public Pagesize10 pageSize { get; set; }
        public Sortname4 sortName { get; set; }
        public Status11 status { get; set; }
    }

    public class Uid12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortvolist
    {
        public string type { get; set; }
        public Struct22 _struct { get; set; }
    }

    public class Struct22
    {
        public Resourcesortvo1 resourceSortVO { get; set; }
    }

    public class Resourcesortvo1
    {
        public string type { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Uid13 uid { get; set; }
        public Content5 content { get; set; }
        public Currentpage11 currentPage { get; set; }
        public Fileuid4 fileUid { get; set; }
        public Keyword11 keyword { get; set; }
        public Pagesize11 pageSize { get; set; }
        public Sortname5 sortName { get; set; }
        public Status12 status { get; set; }
    }

    public class Uid13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolevo
    {
        public string type { get; set; }
        public Struct24 _struct { get; set; }
    }

    public class Struct24
    {
        public Categorymenuuids1 categoryMenuUids { get; set; }
        public Currentpage12 currentPage { get; set; }
        public Keyword12 keyword { get; set; }
        public Pagesize12 pageSize { get; set; }
        public Rolename1 roleName { get; set; }
        public Status13 status { get; set; }
        public Summary6 summary { get; set; }
        public Uid14 uid { get; set; }
    }

    public class Categorymenuuids1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolename1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Studyvideovo
    {
        public string type { get; set; }
        public Struct25 _struct { get; set; }
    }

    public class Struct25
    {
        public Baidupath baiduPath { get; set; }
        public Content6 content { get; set; }
        public Currentpage13 currentPage { get; set; }
        public Fileuid5 fileUid { get; set; }
        public Keyword13 keyword { get; set; }
        public Name1 name { get; set; }
        public Pagesize13 pageSize { get; set; }
        public Resourcesortuid1 resourceSortUid { get; set; }
        public Status14 status { get; set; }
        public Summary7 summary { get; set; }
        public Uid15 uid { get; set; }
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

    public class Currentpage13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Studyvideovolist
    {
        public string type { get; set; }
        public Struct26 _struct { get; set; }
    }

    public class Struct26
    {
        public Studyvideovo1 studyVideoVO { get; set; }
    }

    public class Studyvideovo1
    {
        public string type { get; set; }
        public Struct27 _struct { get; set; }
    }

    public class Struct27
    {
        public Baidupath1 baiduPath { get; set; }
        public Content7 content { get; set; }
        public Currentpage14 currentPage { get; set; }
        public Fileuid6 fileUid { get; set; }
        public Keyword14 keyword { get; set; }
        public Name2 name { get; set; }
        public Pagesize14 pageSize { get; set; }
        public Resourcesortuid2 resourceSortUid { get; set; }
        public Status15 status { get; set; }
        public Summary8 summary { get; set; }
        public Uid16 uid { get; set; }
    }

    public class Baidupath1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourcesortuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid16
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

    public class Uservo
    {
        public string type { get; set; }
        public Struct28 _struct { get; set; }
    }

    public class Struct28
    {
        public Avatar1 avatar { get; set; }
        public Birthday1 birthday { get; set; }
        public Currentpage15 currentPage { get; set; }
        public Email2 email { get; set; }
        public Gender1 gender { get; set; }
        public Keyword15 keyword { get; set; }
        public Mobile1 mobile { get; set; }
        public Nickname2 nickName { get; set; }
        public Occupation1 occupation { get; set; }
        public Pagesize15 pageSize { get; set; }
        public Password3 passWord { get; set; }
        public Qqnumber1 qqNumber { get; set; }
        public Source2 source { get; set; }
        public Status16 status { get; set; }
        public Summary9 summary { get; set; }
        public Uid17 uid { get; set; }
        public Username5 userName { get; set; }
        public Uuid uuid { get; set; }
        public Wechat1 weChat { get; set; }
    }

    public class Avatar1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Birthday1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gender1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Occupation1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Source2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tagvo
    {
        public string type { get; set; }
        public Struct29 _struct { get; set; }
    }

    public class Struct29
    {
        public Content8 content { get; set; }
        public Currentpage16 currentPage { get; set; }
        public Keyword16 keyword { get; set; }
        public Pagesize16 pageSize { get; set; }
        public Sort8 sort { get; set; }
        public Uid18 uid { get; set; }
    }

    public class Content8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tagvolist
    {
        public string type { get; set; }
        public Struct30 _struct { get; set; }
    }

    public class Struct30
    {
        public Tagvo1 tagVO { get; set; }
    }

    public class Tagvo1
    {
        public string type { get; set; }
        public Struct31 _struct { get; set; }
    }

    public class Struct31
    {
        public Content9 content { get; set; }
        public Currentpage17 currentPage { get; set; }
        public Keyword17 keyword { get; set; }
        public Pagesize17 pageSize { get; set; }
        public Sort9 sort { get; set; }
        public Uid19 uid { get; set; }
    }

    public class Content9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sysdictdatavo
    {
        public string type { get; set; }
        public Struct32 _struct { get; set; }
    }

    public class Struct32
    {
        public Cssclass cssClass { get; set; }
        public Currentpage18 currentPage { get; set; }
        public Dictlabel dictLabel { get; set; }
        public Dicttypeuid dictTypeUid { get; set; }
        public Dictvalue dictValue { get; set; }
        public Ispublish2 isPublish { get; set; }
        public Keyword18 keyword { get; set; }
        public Listclass listClass { get; set; }
        public Oid oid { get; set; }
        public Pagesize18 pageSize { get; set; }
        public Remark remark { get; set; }
        public Sort10 sort { get; set; }
        public Status17 status { get; set; }
        public Uid20 uid { get; set; }
    }

    public class Cssclass
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictlabel
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dicttypeuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictvalue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Listclass
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sysdictdatavolist
    {
        public string type { get; set; }
        public Struct33 _struct { get; set; }
    }

    public class Struct33
    {
        public Sysdictdatavo1 sysDictDataVO { get; set; }
    }

    public class Sysdictdatavo1
    {
        public string type { get; set; }
        public Struct34 _struct { get; set; }
    }

    public class Struct34
    {
        public Cssclass1 cssClass { get; set; }
        public Currentpage19 currentPage { get; set; }
        public Dictlabel1 dictLabel { get; set; }
        public Dicttypeuid1 dictTypeUid { get; set; }
        public Dictvalue1 dictValue { get; set; }
        public Ispublish3 isPublish { get; set; }
        public Keyword19 keyword { get; set; }
        public Listclass1 listClass { get; set; }
        public Oid1 oid { get; set; }
        public Pagesize19 pageSize { get; set; }
        public Remark1 remark { get; set; }
        public Sort11 sort { get; set; }
        public Status18 status { get; set; }
        public Uid21 uid { get; set; }
    }

    public class Cssclass1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictlabel1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dicttypeuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictvalue1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Listclass1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dicttypelist
    {
        public string type { get; set; }
        public Struct35 _struct { get; set; }
    }

    public class Struct35
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

    public class Webvisitvo
    {
        public string type { get; set; }
        public Struct36 _struct { get; set; }
    }

    public class Struct36
    {
        public Behavior behavior { get; set; }
        public Behaviorcontent behaviorContent { get; set; }
        public Browser browser { get; set; }
        public Content10 content { get; set; }
        public Currentpage20 currentPage { get; set; }
        public Ip ip { get; set; }
        public Keyword20 keyword { get; set; }
        public Moduleuid moduleUid { get; set; }
        public Os os { get; set; }
        public Otherdata otherData { get; set; }
        public Pagesize20 pageSize { get; set; }
        public Starttime1 startTime { get; set; }
        public Status19 status { get; set; }
        public Uid22 uid { get; set; }
        public Useruid2 userUid { get; set; }
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

    public class Content10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword20
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

    public class Pagesize20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useruid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Webconfigvo
    {
        public string type { get; set; }
        public Struct37 _struct { get; set; }
    }

    public class Struct37
    {
        public Alipay aliPay { get; set; }
        public Alipayphoto aliPayPhoto { get; set; }
        public Author3 author { get; set; }
        public Email3 email { get; set; }
        public Currentpage21 currentPage { get; set; }
        public Gitee1 gitee { get; set; }
        public Github1 github { get; set; }
        public Keyword21 keyword { get; set; }
        public Logo logo { get; set; }
        public Qqgroup qqGroup { get; set; }
        public Pagesize21 pageSize { get; set; }
        public Qqnumber2 qqNumber { get; set; }
        public Recordnum recordNum { get; set; }
        public Showlist showList { get; set; }
        public Startcomment startComment { get; set; }
        public Status20 status { get; set; }
        public Summary10 summary { get; set; }
        public Title3 title { get; set; }
        public Uid23 uid { get; set; }
        public Wechat2 weChat { get; set; }
        public Weixinpay weixinPay { get; set; }
        public Weixinpayphoto weixinPayPhoto { get; set; }
        public Photolist3 photoList { get; set; }
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

    public class Author3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage21
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

    public class Keyword21
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

    public class Pagesize21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qqnumber2
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

    public class Status20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Summary10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Wechat2
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

    public class Photolist3
    {
        public string type { get; set; }
        public Struct38 _struct { get; set; }
    }

    public class Struct38
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Systemconfigvo
    {
        public string type { get; set; }
        public Struct39 _struct { get; set; }
    }

    public class Struct39
    {
        public Currentpage22 currentPage { get; set; }
        public Email4 email { get; set; }
        public Emailpassword emailPassword { get; set; }
        public Emailusername emailUserName { get; set; }
        public Keyword22 keyword { get; set; }
        public Localpicturebaseurl localPictureBaseUrl { get; set; }
        public Pagesize22 pageSize { get; set; }
        public Picturepriority picturePriority { get; set; }
        public Qiniuaccesskey qiNiuAccessKey { get; set; }
        public Qiniuarea qiNiuArea { get; set; }
        public Qiniubucket qiNiuBucket { get; set; }
        public Qiniupicturebaseurl qiNiuPictureBaseUrl { get; set; }
        public Qiniusecretkey qiNiuSecretKey { get; set; }
        public Smtpaddress smtpAddress { get; set; }
        public Smtpport smtpPort { get; set; }
        public Status21 status { get; set; }
        public Uid24 uid { get; set; }
        public Uploadlocal uploadLocal { get; set; }
        public Uploadqiniu uploadQiNiu { get; set; }
    }

    public class Currentpage22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Email4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Emailpassword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Emailusername
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Localpicturebaseurl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picturepriority
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qiniuaccesskey
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qiniuarea
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qiniubucket
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qiniupicturebaseurl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Qiniusecretkey
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Smtpaddress
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Smtpport
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uploadlocal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uploadqiniu
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sysdicttypevo
    {
        public string type { get; set; }
        public Struct40 _struct { get; set; }
    }

    public class Struct40
    {
        public Currentpage23 currentPage { get; set; }
        public Dictname dictName { get; set; }
        public Dicttype dictType { get; set; }
        public Ispublish4 isPublish { get; set; }
        public Keyword23 keyword { get; set; }
        public Oid2 oid { get; set; }
        public Pagesize23 pageSize { get; set; }
        public Remark2 remark { get; set; }
        public Sort12 sort { get; set; }
        public Status22 status { get; set; }
        public Uid25 uid { get; set; }
    }

    public class Currentpage23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dicttype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sysdicttypevolist
    {
        public string type { get; set; }
        public Struct41 _struct { get; set; }
    }

    public class Struct41
    {
        public Sysdicttypevo1 sysDictTypeVO { get; set; }
    }

    public class Sysdicttypevo1
    {
        public string type { get; set; }
        public Struct42 _struct { get; set; }
    }

    public class Struct42
    {
        public Currentpage24 currentPage { get; set; }
        public Dictname1 dictName { get; set; }
        public Dicttype1 dictType { get; set; }
        public Ispublish5 isPublish { get; set; }
        public Keyword24 keyword { get; set; }
        public Oid3 oid { get; set; }
        public Pagesize24 pageSize { get; set; }
        public Remark3 remark { get; set; }
        public Sort13 sort { get; set; }
        public Status23 status { get; set; }
        public Uid26 uid { get; set; }
    }

    public class Currentpage24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dicttype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispublish5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Oid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uid26
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

    public class File
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileids1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fileids2
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
        public Struct43 _struct { get; set; }
    }

    public class Struct43
    {
        public Useruid3 userUid { get; set; }
        public Adminuid2 adminUid { get; set; }
        public Projectname projectName { get; set; }
        public Sortname6 sortName { get; set; }
        public Urllist urlList { get; set; }
        public Systemconfig systemConfig { get; set; }
    }

    public class Useruid3
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

    public class Sortname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Urllist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Systemconfig
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Files
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
        public string[] positions { get; set; }
        public object[] position { get; set; }
    }

}
