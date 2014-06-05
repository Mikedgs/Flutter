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


    #endregion
    
    #region Relationships

    [ReverseAssociation("User")]
    private readonly EntityCollection<FollowTable> _followTablesByUser = new EntityCollection<FollowTable>();
    [ReverseAssociation("Follower")]
    private readonly EntityCollection<FollowTable> _followTablesByFollower = new EntityCollection<FollowTable>();
    [ReverseAssociation("User")]
    private readonly EntityCollection<Tweet> _tweets = new EntityCollection<Tweet>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<FollowTable> FollowTablesByUser
    {
      get { return Get(_followTablesByUser); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<FollowTable> FollowTablesByFollower
    {
      get { return Get(_followTablesByFollower); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Tweet> Tweets
    {
      get { return Get(_tweets); }
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
    [Column("user_id")]
    private int _userId;
    [Column("original_tweet_id")]
    private System.Nullable<int> _originalTweetId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the TweetField entity attribute.</summary>
    public const string TweetFieldField = "TweetField";
    /// <summary>Identifies the CreatedAt entity attribute.</summary>
    public const string CreatedAtField = "CreatedAt";
    /// <summary>Identifies the UpdatedAt entity attribute.</summary>
    public const string UpdatedAtField = "UpdatedAt";
    /// <summary>Identifies the UserId entity attribute.</summary>
    public const string UserIdField = "UserId";
    /// <summary>Identifies the OriginalTweetId entity attribute.</summary>
    public const string OriginalTweetIdField = "OriginalTweetId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("OriginalTweet")]
    private readonly EntityCollection<Tweet> _tweets = new EntityCollection<Tweet>();
    [ReverseAssociation("Tweets")]
    private readonly EntityHolder<User> _user = new EntityHolder<User>();
    [ReverseAssociation("Tweets")]
    private readonly EntityHolder<Tweet> _originalTweet = new EntityHolder<Tweet>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Tweet> Tweets
    {
      get { return Get(_tweets); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public User User
    {
      get { return Get(_user); }
      set { Set(_user, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Tweet OriginalTweet
    {
      get { return Get(_originalTweet); }
      set { Set(_originalTweet, value); }
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

    /// <summary>Gets or sets the ID for the <see cref="User" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int UserId
    {
      get { return Get(ref _userId, "UserId"); }
      set { Set(ref _userId, value, "UserId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="OriginalTweet" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> OriginalTweetId
    {
      get { return Get(ref _originalTweetId, "OriginalTweetId"); }
      set { Set(ref _originalTweetId, value, "OriginalTweetId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class FollowTable : Entity<int>
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

    [ReverseAssociation("FollowTablesByUser")]
    private readonly EntityHolder<User> _user = new EntityHolder<User>();
    [ReverseAssociation("FollowTablesByFollower")]
    private readonly EntityHolder<User> _follower = new EntityHolder<User>();


    #endregion
    
    #region Properties

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
    
    public System.Linq.IQueryable<FollowTable> FollowTables
    {
      get { return this.Query<FollowTable>(); }
    }
    
  }

}
