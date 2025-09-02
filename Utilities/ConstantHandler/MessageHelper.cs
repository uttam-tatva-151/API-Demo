using Common.ConstantHandler.Enums;

namespace Common.ConstantHandler
{
    public class MessageHelper
    {
        /*
               * Operation :- Adding, Deleting, Updating
           */
        #region Success Messages

        public static string GetSuccessMessage(OperationType operation, string entity)
        {
            if (string.IsNullOrWhiteSpace(entity))
            {
                return Messages.GENERAL_SUCCESS; // Default/fallback message
            }

            return operation switch
            {
                OperationType.Read => string.Format(Messages.SUCCESS_READ, entity),
                OperationType.Add => string.Format(Messages.SUCCESS_ADDED, entity),
                OperationType.Update => string.Format(Messages.SUCCESS_UPDATED, entity),
                OperationType.Delete => string.Format(Messages.SUCCESS_DELETED, entity),
                _ => Messages.GENERAL_SUCCESS
            };
        }

        #endregion

        #region Error Messages

        public static string GetErrorMessage(OperationType operation, string entity)
        {
            if (string.IsNullOrWhiteSpace(entity))
            {
                return Messages.GENERAL_ERROR; // Default/fallback message
            }

            return operation switch
            {
                OperationType.Read => string.Format(Messages.ERROR_FEATCHING, entity),
                OperationType.Add => string.Format(Messages.ERROR_ADDING, entity),
                OperationType.Update => string.Format(Messages.ERROR_UPDATING, entity),
                OperationType.Delete => string.Format(Messages.ERROR_DELETING, entity),
                OperationType.NotFound => string.Format(Messages.ERROR_NOT_FOUND, entity),
                _ => Messages.GENERAL_ERROR
            };
        }
        #endregion

        #region Warning Messages

        public static string GetWarningMessage(WarningOperationType operation, string? entity)
        {
            // Fallback entity for those warnings that require a default
            string fallbackEntity = Constants.DEFAULT_ENTITY;

            return operation switch
            {
                WarningOperationType.InvalidInput =>
                    string.IsNullOrWhiteSpace(entity)
                        ? Messages.WARNING_INVALID_CREDENTIALS
                        : string.Format(Messages.WARNING_INVALID_INPUT, entity),

                WarningOperationType.AlreadyExists =>
                    string.Format(Messages.WARNING_ALL_READY_EXISTS, string.IsNullOrWhiteSpace(entity) ? fallbackEntity : entity),

                WarningOperationType.DeleteConfirmation =>
                    string.Format(Messages.WARNING_DELETE_CONFIRMATION, string.IsNullOrWhiteSpace(entity) ? fallbackEntity : entity),
                WarningOperationType.NothingSelected =>
                    string.Format(Messages.WARNING_NOTHING_SELECTED, string.IsNullOrWhiteSpace(entity) ? fallbackEntity : entity),

                _ => string.Empty
            };
        }

        #endregion

        #region Info Messages

        public static string GetInfoMessage(InfoOperationType operation, string entity)
        {
            string arg = string.IsNullOrWhiteSpace(entity) ? Constants.DEFAULT_ENTITY : entity;

            return operation switch
            {
                InfoOperationType.Loading => string.Format(Messages.INFO_LOADING, arg),
                InfoOperationType.NoRecordsFound => string.Format(Messages.INFO_NO_RECORDS_FOUND, arg),
                _ => string.Empty
            };
        }
        #endregion

        #region  Custom Message 

        /* 
            * Tamplate :- "Welcome {0}, your role is {1}."
            * Objects :- "Uttam", "Administrator"

            * Function Calls :- string formattedMessage = MessageHelper.GetCustomMessage(template, "Uttam", "Administrator");

            * Output :- Welcome Uttam, your role is Administrator.
        */
        public static string GetCustomMessage(string template, params object[] args)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(template))
                {
                    return "Message template is missing."; // Handle null or empty template
                }
                return string.Format(template, args);
            }
            catch (FormatException)
            {
                return "An error occurred while formatting the message."; // Handle formatting errors
            }
        }

        #endregion
    }
}

