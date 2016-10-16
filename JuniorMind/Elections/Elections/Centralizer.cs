﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class Centralizer : IEnumerable<PollingStation>
    {
        PollingStation[] pollingStations;

        public Centralizer(PollingStation[] pollingStations)
        {
            this.pollingStations = pollingStations;
        }

        public PollingStation CentralizePollingStations()
        {
            foreach (PollingStation pollingStation in pollingStations)
            {
                pollingStation.SortCandidatesAlphabetically();
            }

            Candidate[] list = new Candidate[pollingStations[0].Candidates.Length];
            pollingStations[0].GetCandidatesList(list);
            AddCandidatesNames(list);
            for (int i = 0; i < pollingStations.Length; i++)
            {
                int k = 0;
                foreach (Candidate candidate in pollingStations[i].Candidates)
                {
                    list[k].NumberOfVotes += candidate.GetNumberOfVotes();
                    k++;
                }
            }

            return new PollingStation(list).SortCandidatesAfterNumberOfVotes();
        }

        private void AddCandidatesNames(Candidate[] candidatesList)
        {
            int i = 0;
            foreach (Candidate candidate in pollingStations[0].Candidates)
            {
                candidatesList[i].CandidateName = candidate.CandidateName;
                i++;
            }
        }

        public IEnumerator<PollingStation> GetEnumerator()
        {
            foreach (PollingStation sortedStation in pollingStations)
            {
                yield return sortedStation;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}