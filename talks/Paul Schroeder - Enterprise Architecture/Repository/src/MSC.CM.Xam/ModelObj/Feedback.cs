// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace MSC.CM.Xam.ModelObj.CM
{
	public partial class Feedback : ObservableObject
	{
		public Feedback()
		{
			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private string _description;
		private bool _dispositioned;
		private int? _featuredEventId;
		private System.Guid _feedbackId;
		private int _feedbackInitiatorTypeId;
		private int _feedbackTypeId;
		private bool? _isChat;
		private bool _isDeleted;
		private bool _isPublic;
		private double _latitude;
		private double _longitude;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private string _ratingValue;
		private int? _sessionId;
		private string _source;
		private string _title;
		private int _userProfileId;


		public string CreatedBy
		{
			get { return _createdBy; }
			set
			{
				Set<string>(() => CreatedBy, ref _createdBy, value);
				RunCustomLogicSetCreatedBy(value);
			}
		}

		public System.DateTime CreatedUtcDate
		{
			get { return _createdUtcDate; }
			set
			{
				Set<System.DateTime>(() => CreatedUtcDate, ref _createdUtcDate, value);
				RunCustomLogicSetCreatedUtcDate(value);
			}
		}

		public int DataVersion
		{
			get { return _dataVersion; }
			set
			{
				Set<int>(() => DataVersion, ref _dataVersion, value);
				RunCustomLogicSetDataVersion(value);
			}
		}

		public string Description
		{
			get { return _description; }
			set
			{
				Set<string>(() => Description, ref _description, value);
				RunCustomLogicSetDescription(value);
			}
		}

		public bool Dispositioned
		{
			get { return _dispositioned; }
			set
			{
				Set<bool>(() => Dispositioned, ref _dispositioned, value);
				RunCustomLogicSetDispositioned(value);
			}
		}

		public int? FeaturedEventId
		{
			get { return _featuredEventId; }
			set
			{
				Set<int?>(() => FeaturedEventId, ref _featuredEventId, value);
				RunCustomLogicSetFeaturedEventId(value);
			}
		}

		public System.Guid FeedbackId
		{
			get { return _feedbackId; }
			set
			{
				Set<System.Guid>(() => FeedbackId, ref _feedbackId, value);
				RunCustomLogicSetFeedbackId(value);
			}
		}

		public int FeedbackInitiatorTypeId
		{
			get { return _feedbackInitiatorTypeId; }
			set
			{
				Set<int>(() => FeedbackInitiatorTypeId, ref _feedbackInitiatorTypeId, value);
				RunCustomLogicSetFeedbackInitiatorTypeId(value);
			}
		}

		public int FeedbackTypeId
		{
			get { return _feedbackTypeId; }
			set
			{
				Set<int>(() => FeedbackTypeId, ref _feedbackTypeId, value);
				RunCustomLogicSetFeedbackTypeId(value);
			}
		}

		public bool? IsChat
		{
			get { return _isChat; }
			set
			{
				Set<bool?>(() => IsChat, ref _isChat, value);
				RunCustomLogicSetIsChat(value);
			}
		}

		public bool IsDeleted
		{
			get { return _isDeleted; }
			set
			{
				Set<bool>(() => IsDeleted, ref _isDeleted, value);
				RunCustomLogicSetIsDeleted(value);
			}
		}

		public bool IsPublic
		{
			get { return _isPublic; }
			set
			{
				Set<bool>(() => IsPublic, ref _isPublic, value);
				RunCustomLogicSetIsPublic(value);
			}
		}

		public double Latitude
		{
			get { return _latitude; }
			set
			{
				Set<double>(() => Latitude, ref _latitude, value);
				RunCustomLogicSetLatitude(value);
			}
		}

		public double Longitude
		{
			get { return _longitude; }
			set
			{
				Set<double>(() => Longitude, ref _longitude, value);
				RunCustomLogicSetLongitude(value);
			}
		}

		public string ModifiedBy
		{
			get { return _modifiedBy; }
			set
			{
				Set<string>(() => ModifiedBy, ref _modifiedBy, value);
				RunCustomLogicSetModifiedBy(value);
			}
		}

		public System.DateTime ModifiedUtcDate
		{
			get { return _modifiedUtcDate; }
			set
			{
				Set<System.DateTime>(() => ModifiedUtcDate, ref _modifiedUtcDate, value);
				RunCustomLogicSetModifiedUtcDate(value);
			}
		}

		public string RatingValue
		{
			get { return _ratingValue; }
			set
			{
				Set<string>(() => RatingValue, ref _ratingValue, value);
				RunCustomLogicSetRatingValue(value);
			}
		}

		public int? SessionId
		{
			get { return _sessionId; }
			set
			{
				Set<int?>(() => SessionId, ref _sessionId, value);
				RunCustomLogicSetSessionId(value);
			}
		}

		public string Source
		{
			get { return _source; }
			set
			{
				Set<string>(() => Source, ref _source, value);
				RunCustomLogicSetSource(value);
			}
		}

		public string Title
		{
			get { return _title; }
			set
			{
				Set<string>(() => Title, ref _title, value);
				RunCustomLogicSetTitle(value);
			}
		}

		public int UserProfileId
		{
			get { return _userProfileId; }
			set
			{
				Set<int>(() => UserProfileId, ref _userProfileId, value);
				RunCustomLogicSetUserProfileId(value);
			}
		}

		public virtual FeaturedEvent FeaturedEvent { get; set; } 
		public virtual FeedbackInitiatorType FeedbackInitiatorType { get; set; } 
		public virtual FeedbackType FeedbackType { get; set; } 
		public virtual Session Session { get; set; } 
		public virtual UserProfile UserProfile { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetDescription(string value);
		partial void RunCustomLogicSetDispositioned(bool value);
		partial void RunCustomLogicSetFeaturedEventId(int? value);
		partial void RunCustomLogicSetFeedbackId(System.Guid value);
		partial void RunCustomLogicSetFeedbackInitiatorTypeId(int value);
		partial void RunCustomLogicSetFeedbackTypeId(int value);
		partial void RunCustomLogicSetIsChat(bool? value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetIsPublic(bool value);
		partial void RunCustomLogicSetLatitude(double value);
		partial void RunCustomLogicSetLongitude(double value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetRatingValue(string value);
		partial void RunCustomLogicSetSessionId(int? value);
		partial void RunCustomLogicSetSource(string value);
		partial void RunCustomLogicSetTitle(string value);
		partial void RunCustomLogicSetUserProfileId(int value);

		#endregion RunCustomLogicSet

	}
}
