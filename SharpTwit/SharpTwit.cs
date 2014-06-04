using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace SharpTwit
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Users")]
  public partial class User : Entity<int>
  {
    #region Fields
  
    [Column("user_name")]
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _userName;
    [ValidatePresence]
    [ValidateEmailAddress]
    [ValidateLength(0, 50)]
    private string _email;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _password;
    [Column("created_at")]
    private System.DateTime _createdAt;
    [Column("updated_at")]
    private System.DateTime _updatedAt;
    private int _followerTableId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the UserName entity attribute.</summary>
    public const string UserNameField = "UserName";
    /// <summary>Identifies the Email entity attribute.</summary>
    public const string EmailField = "Email";
    /// <summary>Identifies the Password entity attribute.</summary>
    public const string PasswordField = "Password";
    /// <summary>Identifies the CreatedAt entity attribute.</summary>
    public const string CreatedAtField = "CreatedAt";
    /// <summary>Identifies the UpdatedAt entity attribute.</summary>
    public const string UpdatedAtField = "UpdatedAt";
    /// <summary>Identifies the FollowerTableId entity attribute.</summary>
    public const string FollowerTableIdField = "FollowerTableId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("User")]
    private readonly EntityCollection<Tweet> _tweets = new EntityCollection<Tweet>();
    [ReverseAssociation("User")]
    private readonly EntityCollection<FollowersTable> _followersTablesByUser = new EntityCollection<FollowersTable>();
    [ReverseAssociation("Follower")]
    private readonly EntityCollection<FollowersTable> _followersTablesByFollower = new EntityCollection<FollowersTable>();
    [ReverseAssociation("Users")]
    private readonly EntityHolder<FollowersTable> _followerTable = new EntityHolder<FollowersTable>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Tweet> Tweets
    {
      get { return Get(_tweets); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<FollowersTable> FollowersTablesByUser
    {
      get { return Get(_followersTablesByUser); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<FollowersTable> FollowersTablesByFollower
    {
      get { return Get(_followersTablesByFollower); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public FollowersTable FollowerTable
    {
      get { return Get(_followerTable); }
      set { Set(_followerTable, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string UserName
    {
      get { return Get(ref _userName, "UserName"); }
      set { Set(ref _userName, value, "UserName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Email
    {
      get { return Get(ref _email, "Email"); }
      set { Set(ref _email, value, "Email"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Password
    {
      get { return Get(ref _password, "Password"); }
      set { Set(ref _password, value, "Password"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime CreatedAt
    {
      get { return Get(ref _createdAt, "CreatedAt"); }
      set { Set(ref _createdAt, value, "CreatedAt"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime UpdatedAt
    {
      get { return Get(ref _updatedAt, "UpdatedAt"); }
      set { Set(ref _updatedAt, value, "UpdatedAt"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="FollowerTable" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int FollowerTableId
    {
      get { return Get(ref _followerTableId, "FollowerTableId"); }
      set { Set(ref _followerTableId, value, "FollowerTableId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Tweets")]
  public partial class Tweet : Entity<int>
  {
    #region Fields
  
    [Column("tweet")]
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _tweetField;
    [Column("created_at")]
    private System.DateTime _createdAt;
    [Column("updated_at")]
    private System.DateTime _updatedAt;
    [Column("original_tweet_id")]
    private int _originalTweetId;
    [Column("user_id")]
    private int _userId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the TweetField entity attribute.</summary>
    public const string TweetFieldField = "TweetField";
    /// <summary>Identifies the CreatedAt entity attribute.</summary>
    public const string CreatedAtField = "CreatedAt";
    /// <summary>Identifies the UpdatedAt entity attribute.</summary>
    public const string UpdatedAtField = "UpdatedAt";
    /// <summary>Identifies the OriginalTweetId entity attribute.</summary>
    public const string OriginalTweetIdField = "OriginalTweetId";
    /// <summary>Identifies the UserId entity attribute.</summary>
    public const string UserIdField = "UserId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Tweets")]
    private readonly EntityHolder<User> _user = new EntityHolder<User>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public User User
    {
      get { return Get(_user); }
      set { Set(_user, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string TweetField
    {
      get { return Get(ref _tweetField, "TweetField"); }
      set { Set(ref _tweetField, value, "TweetField"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime CreatedAt
    {
      get { return Get(ref _createdAt, "CreatedAt"); }
      set { Set(ref _createdAt, value, "CreatedAt"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime UpdatedAt
    {
      get { return Get(ref _updatedAt, "UpdatedAt"); }
      set { Set(ref _updatedAt, value, "UpdatedAt"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public int OriginalTweetId
    {
      get { return Get(ref _originalTweetId, "OriginalTweetId"); }
      set { Set(ref _originalTweetId, value, "OriginalTweetId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="User" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int UserId
    {
      get { return Get(ref _userId, "UserId"); }
      set { Set(ref _userId, value, "UserId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class FollowersTable : Entity<int>
  {
    #region Fields
  
    [Column("user_id")]
    private int _userId;
    [Column("follower_id")]
    private int _followerId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the UserId entity attribute.</summary>
    public const string UserIdField = "UserId";
    /// <summary>Identifies the FollowerId entity attribute.</summary>
    public const string FollowerIdField = "FollowerId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("FollowerTable")]
    private readonly EntityCollection<User> _users = new EntityCollection<User>();
    [ReverseAssociation("FollowersTablesByUser")]
    private readonly EntityHolder<User> _user = new EntityHolder<User>();
    [ReverseAssociation("FollowersTablesByFollower")]
    private readonly EntityHolder<User> _follower = new EntityHolder<User>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<User> Users
    {
      get { return Get(_users); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public User User
    {
      get { return Get(_user); }
      set { Set(_user, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public User Follower
    {
      get { return Get(_follower); }
      set { Set(_follower, value); }
    }


    /// <summary>Gets or sets the ID for the <see cref="User" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int UserId
    {
      get { return Get(ref _userId, "UserId"); }
      set { Set(ref _userId, value, "UserId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Follower" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int FollowerId
    {
      get { return Get(ref _followerId, "FollowerId"); }
      set { Set(ref _followerId, value, "FollowerId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the SharpTwit model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class SharpTwitUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<User> Users
    {
      get { return this.Query<User>(); }
    }
    
    public System.Linq.IQueryable<Tweet> Tweets
    {
      get { return this.Query<Tweet>(); }
    }
    
    public System.Linq.IQueryable<FollowersTable> FollowersTables
    {
      get { return this.Query<FollowersTable>(); }
    }
    
  }

}
