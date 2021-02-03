INSERT INTO Bugs
	(
		[Title],
		[Description],
		[Product],
		[Version],
		[Type]
	)
VALUES
	(
		'netstat -M problem',
		'netstat.c: feature FW_MASQUERADE not supported.',
		'Red Hat Linux',
		'5.2',
		'Usability'
	),
	(
		'ntp: Using port 123 for modes where a fixed port number is not required facilitates off-path attacks.',
		'This is an automatically created tracking bug!',
		'Fedora',
		'29',
		'Security'
	);