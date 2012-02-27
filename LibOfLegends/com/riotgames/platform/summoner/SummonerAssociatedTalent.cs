﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
	public class SummonerAssociatedTalent : AbstractDomainObject
	{
		public int rank;
		public SummonerAssociatedTalentPK comp_id;
		public Talent talent;
	}
}
