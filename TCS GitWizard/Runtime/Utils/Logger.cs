using UnityEngine;
namespace TCS.GitWizard {
    internal static class Logger {
        const string CLASS_NAME = "IAPSystem";
        const string LOG_COLOR = "green";
        const string LOG_COLOR_WARNING = "yellow";
        const string LOG_COLOR_ERROR = "red";
        const string LOG_COLOR_ASSERT = "magenta";
        const string LOG_COLOR_EXCEPTION = "orange";

        static string SetPrefix(this string newString, LogType logType) {
            string color = logType switch {
                LogType.Warning => LOG_COLOR_WARNING,
                LogType.Error => LOG_COLOR_ERROR,
                LogType.Assert => LOG_COLOR_ASSERT,
                LogType.Exception => LOG_COLOR_EXCEPTION,
                _ => LOG_COLOR
            };
            return $"<color={color}>[{newString}]</color>";
        }

        static void LogInternal(object message, LogType logType, Object context = null) {
            var formattedMessage = $"{CLASS_NAME.SetPrefix(logType)} {message}";
            switch (logType) {
                case LogType.Warning:
                    if (!context) {
                        Debug.LogWarning(formattedMessage);
                        break;
                    }

                    Debug.LogWarning(formattedMessage, context);
                    break;
                case LogType.Error:
                    if (!context) {
                        Debug.LogError(formattedMessage);
                        break;
                    }

                    Debug.LogError(formattedMessage, context);
                    break;
                case LogType.Assert:
                    if (!context) {
                        Debug.LogAssertion(formattedMessage);
                        break;
                    }

                    Debug.LogAssertion(formattedMessage, context);
                    break;
                case LogType.Exception:
                    if (!context) {
                        Debug.LogException(new System.Exception(formattedMessage));
                        break;
                    }

                    Debug.LogException(new System.Exception(formattedMessage), context);
                    break;
                case LogType.Log:
                default:
                    if (!context) {
                        Debug.Log(formattedMessage);
                        break;
                    }

                    Debug.Log(formattedMessage, context);
                    break;
            }
        }

        //Without context
        public static void Log(object message) => LogInternal(message, LogType.Log);
        public static void LogWarning(object message) => LogInternal(message, LogType.Warning);
        public static void LogError(object message) => LogInternal(message, LogType.Error);
        public static void LogAssert(object message) => LogInternal(message, LogType.Assert);
        public static void LogException(object message) => LogInternal(message, LogType.Exception);

        //With context
        public static void Log(object message, Object ctx) => LogInternal(message, LogType.Log, ctx);
        public static void LogWarning(object message, Object ctx) => LogInternal(message, LogType.Warning, ctx);
        public static void LogError(object message, Object ctx) => LogInternal(message, LogType.Error, ctx);
        public static void LogAssert(object message, Object ctx) => LogInternal(message, LogType.Assert, ctx);
        public static void LogException(object message, Object ctx) => LogInternal(message, LogType.Exception, ctx);
    }
}