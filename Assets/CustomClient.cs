using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This Client inheritated class acts like Client but using UI elements like buttons and input fields.
/// </summary>
public class CustomClient : Client
{
	[Header("UI References")]
	[SerializeField] private Button m_StartClientButton = null;
	[SerializeField] private Button m_SendToServerButton = null;
	//[SerializeField] 
	public TMP_InputField m_SendToServerInputField;
	[SerializeField] private Button m_SendCloseButton = null;
	//[SerializeField] 
	public TextMeshProUGUI m_ClientLoggerScrollRect;

	//private RectTransform m_ClientLoggerRectTransform = null;
	public TextMeshProUGUI m_ClientLoggerRectTransform;
	public TextMeshProUGUI m_ClientLoggerText;

	//Set UI interactable properties
	private void Awake()
	{
		//Start Client
		m_StartClientButton.onClick.AddListener(base.StartClient);

		//Send to Server
		m_SendToServerButton.interactable = false;
		m_SendToServerButton.onClick.AddListener(SendMessageToServer);

		//SendClose
		m_SendCloseButton.interactable = false;
		m_SendCloseButton.onClick.AddListener(SendCloseToServer);

		//Populate Client delegates
		OnClientStarted = () =>
		{
			//Set UI interactable properties
			m_StartClientButton.interactable = false;
			m_SendToServerButton.interactable = true;
			m_SendCloseButton.interactable = true;
		};

		OnClientClosed = () =>
		{
			//Set UI interactable properties
			m_StartClientButton.interactable = true;
			m_SendToServerButton.interactable = false;
			m_SendCloseButton.interactable = false;
		};

		//UI References
		//m_ClientLoggerRectTransform = m_ClientLoggerScrollRect.GetComponent<RectTransform>();
		m_ClientLoggerRectTransform = m_ClientLoggerScrollRect;
		//m_ClientLoggerText = m_ClientLoggerScrollRect.content.gameObject.GetComponent<Text>();
		m_ClientLoggerText = m_ClientLoggerScrollRect;
	}

	private void SendMessageToServer()
	{
		string newMsg = m_SendToServerInputField.text;
		if (string.IsNullOrEmpty(newMsg))
		{
			m_ClientLoggerText.text += $"\n- Enter message";
			return;
		}
		base.SendMessageToServer(newMsg);
	}

	private void SendCloseToServer()
	{
		base.SendMessageToServer("Close");
		//Set UI interactable properties
		m_SendCloseButton.interactable = false;
	}

	//Custom Client Log
	#region ClientLog
	protected override void ClientLog(string msg)
	{
		base.ClientLog(msg);
		m_ClientLoggerText.text += $"\n- {msg}";

		//Ensure ScrollBar shows last message
		//LayoutRebuilder.ForceRebuildLayoutImmediate(m_ClientLoggerRectTransform);
		//m_ClientLoggerScrollRect.verticalNormalizedPosition = 0f;
	}
	protected override void ClientLog(string msg, Color color)
	{
		base.ClientLog(msg, color);
		m_ClientLoggerText.text += $"\n<color=#{ColorUtility.ToHtmlStringRGBA(color)}>- {msg}</color>";

		//Ensure ScrollBar shows last message
		//LayoutRebuilder.ForceRebuildLayoutImmediate(m_ClientLoggerRectTransform);
		//m_ClientLoggerScrollRect.verticalNormalizedPosition = 0f;
	}
	#endregion
}