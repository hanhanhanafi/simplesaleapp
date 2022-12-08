using AppPenjualan.Application.TransactionDetailServices.Dto;
using AppPenjualan.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Application.TransactionDetailServices
{
    
    public class TransactionDetailAppService : ITransactionDetailAppService
    {
        private readonly PenjualanContext _penjualanContext;
        private IMapper _mapper;

        public TransactionDetailAppService(PenjualanContext penjualanContext, IMapper mapper)
        {
            _penjualanContext = penjualanContext;
            _mapper = mapper;   
        } 

        public void Create(CreateTransactionDetailDto model)
        {
            var transactionDetail = _mapper.Map<Transactions>(model);
            _penjualanContext.Transactions.Add(transactionDetail);
            _penjualanContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var transactionDetails = _penjualanContext.TransactionDetails.FirstOrDefault(w => w.TransactionDetailsId == id);
            if (transactionDetails != null)
            {
                _penjualanContext.TransactionDetails.Remove(transactionDetails);
                _penjualanContext.SaveChanges(true);
            }
        }

        public List<TransactionDetailListDto> GetTransactionDetail(int TransactionId)
        {
            var trasanctionDetailList = _penjualanContext.TransactionDetails.ToList();
            var transactionDetailListDto = _mapper.Map<List<TransactionDetailListDto>>(trasanctionDetailList);
            return transactionDetailListDto;
        }

        public void Update(UpdateTransactionDetailDto model)
        {
            var transactionDetail = _mapper.Map<Transactions>(model);
            _penjualanContext.Transactions.Update(transactionDetail);
            _penjualanContext.SaveChanges();
        }
    }
}
