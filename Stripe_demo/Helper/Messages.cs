namespace DatingApp.Common.Helpers
{
    public class Messages
    {
        #region General
        public const string Error = "An error occurred. Please try again.";
        public const string RecordNotFound = "No records found";
        public const string RecordFound = "Records found";
        public const string UserNotRegistered = "User not registered. Please register first.";
        public const string EnterValidDetails = "Please enter mobile number and valid otp.";
        public const string AlreadyExists = "Please enter different name as it already exists.";
        public const string InvalidId = "Please enter valid id.";
        public const string InvalidEmailAddress = "Please enter valid email address.";
        public const string InvalidPlan = "Please enter valid plan id.";
        #endregion

        #region Admin
        public const string AdminSaveSuccess = "Admin user created successfully.";
        public const string AdminUpdateSuccess = "Admin user updated successfully.";
        public const string AdminSaveError = "Error while saving admin user.";
        public const string SameEmail = "A record with same email already exists.";
        public const string UserNotFound = "User not found.";
        public const string UserFound = "User found.";
        public const string PasswordUpdateSuccess = "Password updated successfully.";
        public const string PasswordUpdateError = "Error! Please make sure old password is correct.";
        public const string AdminDeleteSuccess = "Admin user deleted successfully.";
        public const string AdminDeleteError = "Error in deleting admin user.";
        public const string StatusUpdateSuccess = "Status updated successfully";
        public const string StatusUpdateError = "Error in updating status. Please try again.";
        public const string SelectImages = "Please select images.";
        public const string InvalidToken = "Token is invalid.";
        public const string EmailNotConfirm = "Email is not confirmed.";
        public const string EmailConfirm = "Your email has been successfully confirmed.";
        public const string InvalidEmailRequest = "Invalid email confirmation request.";
        public const string ForgotPasswordMailSuccess = "Reset password link has been sent successfuly to your email.";
        public const string LinkExpire = "The reset password link has expired. Please try again.";
        public const string ValidMobileNo = "Please enter valid mobile number.";
        public const string InvalidPassword = "Please enter valid password.";
        #endregion

        #region Login/Logout
        public const string LoginSuccess = "User logged in successfully.";
        public const string LoginFailed = "Login failed. Please try again.";
        public const string AccountExists = "Mobile number already exists.";
        public const string EmailExists = "Email already exists.";
        public const string InActiveUser = "User is Inactive.";
        public const string DeletedUser = "User is deleted.";
        public const string InvalidOTP = "Invalid OTP.";
        public const string OTPExpired = "OTP expired.";
        public const string OTPSentSuccess = "OTP sent successfully.";
        public const string ServiceUnavailable = "Service is not available.";
        public const string MobileDoesNotExist = "Mobile number does not exist.";
        public const string LoginError = "Please enter valid email or password.";
        #endregion

        #region ContentManagement
        public const string DeleteContentSuccess = "Content deleted successfully.";
        public const string DeleteContentError = "Error occurred while deleting content.";
        public const string ChangeContentStatusSuccess = "Content changed successfully.";
        public const string ChangeContentStatusError = "Error occurred while changing content.";
        public const string UpdateContentSuccess = "Content updated successfully.";
        public const string InsertContentSuccess = "Content added successfully.";
        public const string ContentNameExists = "Content Name already exists.";
        #endregion

        #region QuoteManagement
        public const string DeleteQuoteSuccess = "Quote deleted successfully.";
        public const string DeleteQuoteError = "Error occurred while deleting quote.";
        public const string ChangeQuoteStatusSuccess = "Quote changed successfully.";
        public const string ChangeQuoteStatusError = "Error occurred while changing quote.";
        public const string UpdateQuoteSuccess = "Quote updated successfully.";
        public const string InsertQuoteSuccess = "Quote added successfully.";
        public const string QuoteNotFound = "No active quotes found locally.";
        public const string ActiveQuoteNotFound = "No active quotes found.";
        #endregion

        #region SubscriptionManagement
        public const string AddStripePlanSuccess = "Stripe Plan Added";
        public const string AddStripePlanError = "Error while adding stripe plan";
        public const string StripeCustomerSuccess = "Stripe Customer Created";
        public const string StripeCustomerError = "Error while creating Stripe Customer";
        public const string DeleteSubscriptionSuccess = "Subscription deleted successfully.";
        public const string DeleteSubscriptionError = "Error occurred while deleting subscription.";
        public const string ChangeSubscriptionStatusSuccess = "Subscription changed successfully.";
        public const string ChangeSubscriptionStatusError = "Error occurred while changing subscription.";
        public const string UpdateSubscriptionSuccess = "Subscription updated successfully.";
        public const string UpdateSubscriptionError = "Error while Processiong Update Subscription, Please try again later";
        public const string InsertSubscriptionSuccess = "Subscription added successfully.";
        public const string StripeUserListByIdSuccess = "StripeUserList get successfully";
        public const string FetchLisError = "Error occurred while fetch list";
        public const string CardAdded = "Card added!";
        public const string DuplicateCard = "Duplicate Card found! Please add new Card";
        public const string CustomerNotFound = "Customer Not Found";
        #endregion

        #region Coach
        public const string DeleteCoachSuccess = "Coach deleted successfully.";
        public const string DeleteCoachError = "Error occurred while deleting coach.";
        public const string ChangeCoachStatusSuccess = "Coach changed successfully.";
        public const string ChangeCoachStatusError = "Error occurred while changing coach.";
        public const string UpdateCoachSuccess = "Coach updated successfully.";
        public const string UpdateCoachError = "Error in updating coach details.";
        public const string InsertCoachSuccess = "Coach added successfully.";
        public const string AlreadyFollowCoach = "Already following coach.";
        public const string FollowCoachSuccess = "Followed coach successfully.";
        public const string FollowCoachError = "Error in following coach.";
        public const string UnFollowCoachSuccess = "Unfollowed coach successfully.";
        public const string UnFollowCoachError = "Error in unfollowing coach.";
        public const string CoachFound = "Coach details found.";
        public const string CoachNotFound = "Record not found.";
        #endregion

        #region Match/Unmatch
        public const string UserRejectedSuccess = "User rejected successfully.";
        public const string UserRejectedError = "Error while rejecting user.";
        public const string UserAlreadyRejected = "User already rejected.";
        public const string UserLikedSuccess = "Match request sent successfully.";
        public const string Userlikedlimitexceed = "Cannot send/accept more than 3 request.";
        public const string UserLikedError = "Error while sending match request.";
        public const string UserAlreadyLiked = "User already liked.";
        public const string UserRequestListSuccess = "Get UserRequestList successfully.";
        public const string UserRequestListError = "Error while fetching users.";
        public const string UserMaybeSuccess = "User added to maybe list successfully.";
        public const string UserMaybeError = "Error while adding user to maybe list.";
        public const string UserAlreadyMaybe = "User already added to maybe list.";
        public const string UserReqestAccepted = "User Request Accepted successfully.";
        public const string UserReqestRejected = "User Request Rejected successfully.";
        public const string UnfriendFriend = "User unfriend successfully.";
        public const string LimitReached = "You have reached your max limit. Upgrade for more.";
        public const string MaxLimitReached = "You have reached your max limit.";
        public const string UserAlreadySendReq = "User already send you friend request.";
        #endregion

        #region PortalUser
        public const string UserSaveSuccess = "User created successfully.";
        public const string UserSaveError = "Error while registering user.";
        public const string UserUpdateSuccess = "User profile updated successfully.";
        public const string UserUpdateError = "Error while updating user profile.";
        public const string UserDeleteSuccess = "User deleted successfully.";
        public const string UserDeleteError = "Error while updating user.";
        public const string PreferenceUpdateSuccess = "User updated successfully.";
        public const string PreferenceUpdateError = "Error while updating user.";
        public const string FCMTokenSuccess = "FCMToken updated successfully.";
        public const string FCMTokenError = "FCMToken not update.";
        public const string UpcomingSession = "Get upcoming sessions list successfully";
        public const string UpcomingSessionError = "Error while getting upcoming session list";
        public const string UserProfileUpdateSuccess = "User image uploaded successfully.";
        public const string UserProfileRemoveSuccess = "User image removed successfully.";
        #endregion

        #region Session
        public const string BookSessionSuccessful = "Your session booked successfully.";
        public const string SessionAlreadyExists = "The session you're trying to book is already booked by you.";
        public const string SessionAccept = "Session accepted successfully.";
        public const string SessionAcceptError = "Error in accepting session.";
        public const string SessionReject = "Session rejected successfully.";
        public const string SessionRejectError = "Error in rejecting session.";
        public const string SessionComplete = "Session completed successfully.";
        public const string SessionCompleteError = "Error in completing session.";
        public const string UnpaidUser = "You need to subscribe first to book session.";
        public const string UserNotificationUpdateSuccess = "Status updated successfully.";
        public const string UserNotificationUpdateError = "Error in updating status.";
        public const string DeleteSessionSuccess = "Session completed successfully.";
        public const string DeleteSessionError = "Session completed successfully.";
        public const string UpcomingSessionSentSuccess = "Session completed successfully.";
        public const string UpcomingSessionSentError = "Session completed successfully.";
        #endregion

        #region Education
        public const string DeleteEducationSuccess = "Education deleted successfully.";
        public const string DeleteEducationError = "Error occurred while deleting education.";
        public const string UpdateEducationSuccess = "Education details updated successfully.";
        public const string InsertEducationSuccess = "Education details added successfully.";
        #endregion

        #region Ethnicity
        public const string DeleteEthnicitySuccess = "Ethnicity deleted successfully.";
        public const string DeleteEthnicityError = "Error occurred while deleting ethnicity.";
        public const string UpdateEthnicitySuccess = "Ethnicity details updated successfully.";
        public const string InsertEthnicitySuccess = "Ethnicity details added successfully.";
        #endregion

        #region Flicker
        public const string DeleteFlickerSuccess = "Flicker deleted successfully.";
        public const string DeleteFlickerError = "Error occurred while deleting flicker.";
        public const string UpdateFlickerSuccess = "Flicker details updated successfully.";
        public const string InsertFlickerSuccess = "Flicker details added successfully.";
        #endregion

        #region Food
        public const string DeleteFoodSuccess = "Food & Drink deleted successfully.";
        public const string DeleteFoodError = "Error occurred while deleting food & drink.";
        public const string UpdateFoodSuccess = "Food & Drink details updated successfully.";
        public const string InsertFoodSuccess = "Food & Drink details added successfully.";
        #endregion

        #region Innovation
        public const string DeleteInnovationSuccess = "Innovation deleted successfully.";
        public const string DeleteInnovationError = "Error occurred while deleting innovation.";
        public const string UpdateInnovationSuccess = "Innovation details updated successfully.";
        public const string InsertInnovationSuccess = "Innovation details added successfully.";
        #endregion

        #region Movie
        public const string DeleteMovieSuccess = "Movie deleted successfully.";
        public const string DeleteMovieError = "Error occurred while deleting movie.";
        public const string UpdateMovieSuccess = "Movie details updated successfully.";
        public const string InsertMovieSuccess = "Movie details added successfully.";
        #endregion

        #region Music
        public const string DeleteMusicSuccess = "Music deleted successfully.";
        public const string DeleteMusicError = "Error occurred while deleting music.";
        public const string UpdateMusicSuccess = "Music details updated successfully.";
        public const string InsertMusicSuccess = "Music details added successfully.";
        #endregion

        #region Probes
        public const string DeleteProbeSuccess = "Probe deleted successfully.";
        public const string DeleteProbeError = "Error occurred while deleting probe.";
        public const string UpdateProbeSuccess = "Probe details updated successfully.";
        public const string InsertProbeSuccess = "Probe details added successfully.";
        #endregion

        #region Religion
        public const string DeleteReligionSuccess = "Religion deleted successfully.";
        public const string DeleteReligionError = "Error occurred while deleting religion.";
        public const string UpdateReligionSuccess = "Religion details updated successfully.";
        public const string InsertReligionSuccess = "Religion details added successfully.";
        #endregion

        #region Scrutiny
        public const string DeleteScrutinySuccess = "Reading deleted successfully.";
        public const string DeleteScrutinyError = "Error occurred while deleting reading.";
        public const string UpdateScrutinySuccess = "Reading details updated successfully.";
        public const string InsertScrutinySuccess = "Reading details added successfully.";
        #endregion

        #region Sports
        public const string DeleteSportSuccess = "Sport deleted successfully.";
        public const string DeleteSportError = "Error occurred while deleting sport.";
        public const string UpdateSportSuccess = "Sport details updated successfully.";
        public const string InsertSportSuccess = "Sport details added successfully.";
        #endregion

        #region Sqaut
        public const string DeleteSqautSuccess = "Sqaut deleted successfully.";
        public const string DeleteSqautError = "Error occurred while deleting sqaut.";
        public const string UpdateSqautSuccess = "Sqaut details updated successfully.";
        public const string InsertSqautSuccess = "Sqaut details added successfully.";
        #endregion

        #region Treasure
        public const string DeleteTreasureuccess = "Treasure deleted successfully.";
        public const string DeleteTreasureError = "Error occurred while deleting treasure.";
        public const string UpdateTreasureSuccess = "Treasure details updated successfully.";
        public const string InsertTreasureSuccess = "Treasure details added successfully.";
        #endregion

        #region ContactUs
        public const string InsertContactSuccess = "Your details sent successfully.";
        public const string InsertContactError = "Error in save contact us details. Please try again later.";
        #endregion

        #region FeedPage
        public const string FeedRecordFound = "Feed Page records found.";
        #endregion

        #region Donation
        public const string AddDonationSuccess = "Donation recived successfully.";
        public const string AddDonationError = "Donation details not added Successfully.";
        public const string ErrorAddDonation = "Error in adding donation. Please try again.";
        public const string DonationsList = "Donations list.";
        #endregion

        #region Dashboard
        public const string DashboardFound = "Dashboard details found.";
        public const string DashboardNotFound = "Dashboard details not found.";
        #endregion

        #region Chat
        public const string ChatListFound = "Chat list found.";
        public const string FilesSent = "File sent successfully.";
        #endregion

        #region ScheduleMysteryRoom
        public const string DeleteScheduleMysteryRoomSuccess = "Schedule deleted successfully.";
        public const string DeleteScheduleMysteryRoomError = "Error occurred while deleting schedule.";
        public const string UpdateScheduleMysteryRoomSuccess = "Schedule details updated successfully.";
        public const string InsertScheduleMysteryRoomSuccess = "Schedule details added successfully.";
        #endregion

        #region MysteryRoom
        public const string RequestSuccess = "Request sent successfully.";
        public const string AlreadyRequestSent = "Request already sent.";
        #endregion

        #region Notification
        public const string NotificationSuccess = "Notification sent successfully.";
        public const string NotificationError = "User is offline.";
        #endregion

        #region Subscription  
        public const string SubscriptionCancelError = "Error while cancelling please try again later";
        public const string AddCardSuccess = "Card successfully added";
        public const string AddCardError = "Error while Creating Card";
        public const string CreateCustumerError = "Error while Creating Customer";
        public const string CreateCustumerSuccess = "Customer Subscription Created";
        public const string ExistingCard = "This card has been already exists.";
        public const string SetDefaultCardSuccess = "Default card set successfully.";
        public const string SetDefaultCardError = "Set Default card failed.";
        public const string CardDetailsNotFound = "User card details not found";
        public const string CardAttachedSuccess = "Card Attached to customer";
        public const string CardAttachedError = "Error while attach card to customer";
        public const string CreateSubscriptionError = "Error while creating Subscription";
        public const string StripePlanFound = "Stripe Plan Found";

        #endregion

        #region Donation
        public const string DonationError = "Donation failed";
        public const string DonationSuccess = "Donation Success";
        #endregion
        #region RemoveCard
        public const string RemoveCardSuccess = "Card removed successfully";
        public const string RemoveCardError = "Error occurred while card removed.";
        #endregion
    }
}
